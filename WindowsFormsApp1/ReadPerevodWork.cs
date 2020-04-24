using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadPerevodWork : Form
    {
        private long idPrikaz;
        private bool flagWork = false;
        private decimal pk_podr = -1;
        private decimal pk_dolzhn = -1;
        private decimal pk_prof = -1;
        
        public ReadPerevodWork()
        {
            InitializeComponent();
        }

        public ReadPerevodWork(long id)
        {
            idPrikaz = id;
            InitializeComponent();
            initData(id);
        }

        private void initData(long id)
        {
            Model1 model = new Model1();
            var org = model.OUR_ORG.FirstOrDefault(c => c.PK_OUR_ORG == 1);
            if (org == null) 
                return;
            textBox11.Text = org.NAME;
            textBox12.Text = "0301004";

            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (prikaz == null) return;
            var selectedMen =  prikaz.PERSONCARD;
            textBox1.Text = selectedMen.SURNAME;
            textBox2.Text = selectedMen.NAME;
            textBox3.Text = selectedMen.MIDDLENAME;
            
            textBox4.Text = selectedMen.TABEL_NUM.ToString();
            
            textBox5.Text = selectedMen.TABEL == null ? null : selectedMen.TABEL.PODRAZDELORG.NAME;
            textBox6.Text = selectedMen.JOB_POSITION == null ? null : selectedMen.JOB_POSITION.NAME;
            textBox7.Text = selectedMen.PROFESSION == null ? null : selectedMen.PROFESSION.NAME;
            
            textBox13.Text = prikaz.OKPO;
            textBox14.Text = prikaz.NUMDOC; 
            dateTimePicker1.Value = prikaz.CREATEDATE.Value;

            var perevod = model.PEREVOD.FirstOrDefault(u => u.PK_PRIKAZ == idPrikaz);
            dateTimePicker4.Value = perevod.ENDWORKDATE == null ? new DateTime(2020, 1, 1) : perevod.ENDWORKDATE.Value; 
            dateTimePicker2.Value = perevod.STARTWORKDATE == null ? new DateTime(2020, 1, 1) : perevod.STARTWORKDATE.Value;
            textBoxPrichinaPerevoda.Text = perevod.REASON;
            
            // данные о старом месте работы
            var dolzhn = model.JOB_POSITION.FirstOrDefault(d => d.PK_JOB_POS == perevod.PK_NEW_JOB_POS);
            var podr = model.PODRAZDELORG.FirstOrDefault(po => po.PK_PODRAZDEL == perevod.PK_NEW_PODRAZDEL);
            var prof = model.PROFESSION.FirstOrDefault(p => p.PK_PROF == perevod.PK_NEW_PROF);
            comboBoxPodr.SelectedItem = podr.NAME;
            textBoxNewDolzhn.Text = dolzhn.NAME;
            textBoxNewProf.Text = prof.NAME;
            
            var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == perevod.PK_NEW_JOB_POS);
            if (strStat == null) return;
            numericUrerpDownTarifStavk.Value = Math.Round((decimal)strStat.TARIFF);
            numericUpDownNadbavk.Value = Math.Round((decimal) strStat.NADBAVKA1);

            comboBoxVid.SelectedItem = perevod.TYPE;

            if (prikaz.ISPROJECT == "1")
            {
                buttonConfirm.Enabled = false;
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
            // закрываем форму
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var priem = model.PEREVOD.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.PEREVOD.Remove(model.PEREVOD.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.PRIKAZ.Remove(model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            model.SaveChanges();
            // закрываем форму
            Close();
        }
    }
}