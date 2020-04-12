using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditPriemPrikaz : Form
    {
        private long idPrikaz;
        public EditPriemPrikaz()
        {
            InitializeComponent();
        }
        
        public EditPriemPrikaz(long id)
        {
            idPrikaz = id;
            InitializeComponent();
            initData(id);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            } 
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
            textBox8.Text = selectedMen.CHARACTER_WORK == null ? null : selectedMen.CHARACTER_WORK.NAME;
            textBox9.Text = priem.CONDITIONS;
            
            if (selectedMen.JOB_POSITION != null)
            {
                var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == selectedMen.JOB_POSITION.PK_JOB_POS);
                if (strStat == null) return;
                numericUrerpDown1.Value = (decimal) strStat.TARIFF;
                numericUrerpDown1.Value = (decimal) strStat.NADBAVKA1;
            }
            
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
            prikaz.OKPO = textBox13.Text;
            prikaz.OKUD = "0301001";
            prikaz.NUMDOC = textBox14.Text;
            prikaz.CREATEDATE = dateTimePicker1.Value;
            prikaz.OUR_ORG = model.OUR_ORG.FirstOrDefault(ourOrg => ourOrg.NAME == textBox11.Text);
            prikaz.TYPE_PRIKAZ = model.TYPE_PRIKAZ.FirstOrDefault(type => type.PK_TYPE == 1);
            // сохраним изменения в бд
            model.SaveChanges();
            
            // изменим сущность ПРИЕМ
            var priem = model.PRIEM.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem == null) return;
            priem.STARTWORKDATE = dateTimePicker4.Value;
            if (checkBox1.Checked) priem.ENDWORKDATE = dateTimePicker2.Value;
            priem.TESTPERIOD = numericUpDown4.Value;
            priem.CONDITIONS = textBox9.Text;
            // TODO
            priem.PODRAZDELORG = model.PODRAZDELORG.FirstOrDefault(podr => podr.PK_PODRAZDEL == 1);
            priem.JOB_POSITION = model.JOB_POSITION.FirstOrDefault(job => job.PK_JOB_POS == 1);
            priem.CHARACTER_WORK = model.CHARACTER_WORK.FirstOrDefault(cha => cha.PK_CHAR_WORK == 1);
            priem.PODRAZDELORG_PK_PODRAZDEL = 1;
            
            // сохраним изменения в бд
            model.SaveChanges();
            // закрываем форму
            Close();
        }
    }
}