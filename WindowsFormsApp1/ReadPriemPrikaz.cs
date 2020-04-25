using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadPriemPrikaz : Form
    {
        private long idPrikaz;
        public ReadPriemPrikaz()
        {
            InitializeComponent();
        }
        
        public ReadPriemPrikaz(long id)
        {
            idPrikaz = id;
            InitializeComponent();
            initData(id);
        }

        
        private void initData(long id)
        {
            Model1 model = new Model1();
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == id);
            if (prikaz == null ) return;
            var priem = model.PRIEM.FirstOrDefault(p => p.PK_PRIKAZ == id);
            if (priem == null ) return;

            dateTimePicker4.Value = priem.STARTWORKDATE.Value;
            if (priem.ENDWORKDATE != null)
                dateTimePicker2.Value = priem.ENDWORKDATE.Value;
            if (prikaz.ISPROJECT == "1") buttonConfirm.Enabled = false;

            dateTimePicker1.Value = prikaz.CREATEDATE.Value;
            
            textBox11.Text = prikaz.OUR_ORG.NAME;
            textBox12.Text = "0301001";
            textBox13.Text = prikaz.OUR_ORG.OKPO;
            textBox14.Text = prikaz.NUMDOC;

            var selectedMen =  prikaz.PERSONCARD;
            textBox1.Text = selectedMen.SURNAME;
            textBox2.Text = selectedMen.NAME;
            textBox3.Text = selectedMen.MIDDLENAME;
            
            textBox4.Text = selectedMen.TABEL_NUM.ToString();
            
            var dolzhn = model.JOB_POSITION.FirstOrDefault(d => d.PK_JOB_POS == priem.PK_JOB_POS);
            var podr = model.PODRAZDELORG.FirstOrDefault(po => po.PK_PODRAZDEL == priem.PK_PODR);
            var prof = model.PROFESSION.FirstOrDefault(p => p.PK_PROF == selectedMen.PK_PROF);
            comboBoxPodr.SelectedItem = podr.NAME;
            textBoxNewDolzhn.Text = dolzhn.NAME;
            textBoxNewProf.Text = prof.NAME;
            
            var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == priem.PK_JOB_POS);
            if (strStat == null) return;
            numericUrerpDownTarifStavk.Value = Math.Round((decimal)strStat.TARIFF);
            numericUpDownNadbavk.Value = Math.Round((decimal) strStat.NADBAVKA1);
            
            textBox8.Text = selectedMen.CHARACTER_WORK == null ? null : selectedMen.CHARACTER_WORK.NAME;
            textBox9.Text = priem.CONDITIONS;
            
            numericUpDown4.Value = priem.TESTPERIOD.Value;
            if (prikaz.ISPROJECT == "1")
            {
                buttonConfirm.Enabled = false;
            }
            else
            {
                buttonConfirm.Enabled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (prikaz == null ) return;
            prikaz.ISPROJECT = "1";
            model.SaveChanges();
            var priem = model.PRIEM.FirstOrDefault(u => u.PK_PRIKAZ == prikaz.PK_PRIKAZ);
            var personcard = prikaz.PERSONCARD;
            personcard.JOB_POSITION_PK_JOB_POS = priem.PK_JOB_POS;
            model.SaveChanges();
            // закрываем форму
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var priem = model.PRIEM.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.PRIEM.Remove(model.PRIEM.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.PRIKAZ.Remove(model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            model.SaveChanges();
            // закрываем форму
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditPriemPrikaz editPriemPrikaz = new EditPriemPrikaz(idPrikaz);
            editPriemPrikaz.Show();
        }
    }
}