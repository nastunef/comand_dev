using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadPriemPrikaz : Form
    {
        public ReadPriemPrikaz()
        {
            InitializeComponent();
        }
        
        public ReadPriemPrikaz(long id)
        {
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
        }
    }
}