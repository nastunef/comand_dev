using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadPerevodToWorkPrikaz : Form
    {
        private long idPrikaz;
        public ReadPerevodToWorkPrikaz()
        {
            InitializeComponent();
        }
        
        public ReadPerevodToWorkPrikaz(long id)
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
            /*
            if (prikaz.ISPROJECT == "1") buttonConfirm.Enabled = false;
            */

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
            
            textBox5.Text = selectedMen.TABEL == null ? null : selectedMen.TABEL.PODRAZDELORG.NAME;
            textBox6.Text = selectedMen.JOB_POSITION == null ? null : selectedMen.JOB_POSITION.NAME;
            textBox7.Text = selectedMen.PROFESSION == null ? null : selectedMen.PROFESSION.NAME;
           
            
            if (selectedMen.JOB_POSITION != null)
            {
                var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == selectedMen.JOB_POSITION.PK_JOB_POS);
                if (strStat == null) return;
                numericUrerpDownTarifStavk.Value = (decimal) strStat.TARIFF;
                numericUpDownNadbavk.Value = (decimal) strStat.NADBAVKA1;
            }
            
            /*if (prikaz.ISPROJECT == "1")
            {
                buttonConfirm.Enabled = false;
            }
            else
            {
                buttonConfirm.Enabled = true;
            }*/
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