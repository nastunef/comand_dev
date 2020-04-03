using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PriemWorkPrikaz : Form
    {
        public PriemWorkPrikaz()
        {
            InitializeComponent();
        }

        public PriemWorkPrikaz(decimal tabNumber)
        {
            InitializeComponent();
            initData(tabNumber);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelWorkPrikaz deleteWork = new DelWorkPrikaz();
            deleteWork.Show();
        }

        
        private void initData(decimal tabNumber)
        {
            Model1 model = new Model1();
            var org = model.OUR_ORG.FirstOrDefault(c => c.PK_OUR_ORG == 1);
            if (org == null) 
                return;
            string numberDoc = "12345678";
            var prikaz = model.PRIKAZ.FirstOrDefault();
            if (prikaz != null)
            {
                numberDoc = model.PRIKAZ.Max(num => num.NUMDOC);
                int numberDocInt = 0;
                Int32.TryParse(numberDoc, out numberDocInt);
                numberDocInt++;
                numberDoc = numberDocInt.ToString();
            }
            textBox11.Text = org.NAME;
            textBox11.Enabled = false;
            textBox12.Text = "0301001";
            textBox13.Text = org.OKPO;
            textBox14.Text = numberDoc;
            
            var selectedMen = model.PERSONCARD.FirstOrDefault(men => men.TABEL_NUM == tabNumber);
            if (selectedMen == null) return;
            idSelectMen = (long) selectedMen.PK_PERSONCARD;
            textBox1.Text = selectedMen.SURNAME;
            textBox2.Text = selectedMen.NAME;
            textBox3.Text = selectedMen.MIDDLENAME;
            
            textBox4.Text = selectedMen.TABEL_NUM.ToString();
            
            textBox5.Text = selectedMen.TABEL == null ? null : selectedMen.TABEL.PODRAZDELORG.NAME;
            textBox6.Text = selectedMen.JOB_POSITION == null ? null : selectedMen.JOB_POSITION.NAME;
            textBox7.Text = selectedMen.PROFESSION == null ? null : selectedMen.PROFESSION.NAME;
            textBox8.Text = selectedMen.CHARACTER_WORK == null ? null : selectedMen.CHARACTER_WORK.NAME;

            if (selectedMen.JOB_POSITION != null)
            {
                var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == selectedMen.JOB_POSITION.PK_JOB_POS);
                if (strStat == null) return;
                numericUrerpDown1.Value = (decimal) strStat.TARIFF;
                numericUrerpDown1.Value = (decimal) strStat.NADBAVKA1;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            long newId = 0;
            // добавим сущность приказ в бд
            newId = model.PRIKAZ.Max(pr => pr.PK_PRIKAZ) + 1;
            var newPrikaz = new PRIKAZ();
            newPrikaz.PK_PRIKAZ = newId;
            newPrikaz.OKPO = textBox13.Text;
            newPrikaz.OKUD = "0301001";
            newPrikaz.NUMDOC = textBox14.Text;
            newPrikaz.CREATEDATE = dateTimePicker1.Value;
            newPrikaz.PERSONCARD = model.PERSONCARD.FirstOrDefault(men => men.PK_PERSONCARD == idSelectMen);
            newPrikaz.OUR_ORG = model.OUR_ORG.FirstOrDefault(ourOrg => ourOrg.NAME == textBox11.Text);
            newPrikaz.ISPROJECT = "0";
            newPrikaz.TYPE_PRIKAZ = model.TYPE_PRIKAZ.FirstOrDefault(type => type.PK_TYPE == 1);
            model.PRIKAZ.Add(newPrikaz);
            model.SaveChanges();
            
            // добавим сущность ПРИЕМ
            long newIdPriem = 0;
            // добавим сущность приказ в бд
             newIdPriem = (long) (model.PRIEM.Max(pr => pr.PK_PRIEM) + 1);
            var newPriem = new PRIEM();
            newPriem.PK_PRIEM = newIdPriem;
            newPriem.STARTWORKDATE = dateTimePicker4.Value;
            if (checkBox1.Checked) newPriem.ENDWORKDATE = dateTimePicker2.Value;
            newPriem.TESTPERIOD = numericUpDown4.Value;
            newPriem.CONDITIONS = textBox9.Text;
            newPriem.PRIKAZ = model.PRIKAZ.FirstOrDefault(prr => prr.PK_PRIKAZ == newId);
            // TODO
            newPriem.PODRAZDELORG = model.PODRAZDELORG.FirstOrDefault(podr => podr.PK_PODRAZDEL == 1);
            newPriem.JOB_POSITION = model.JOB_POSITION.FirstOrDefault(job => job.PK_JOB_POS == 1);
            newPriem.CHARACTER_WORK = model.CHARACTER_WORK.FirstOrDefault(cha => cha.PK_CHAR_WORK == 1);
            newPriem.PODRAZDELORG_PK_PODRAZDEL = 1;
            //
            model.PRIEM.Add(newPriem);
            model.SaveChanges();
            
            // закрываем форму
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}