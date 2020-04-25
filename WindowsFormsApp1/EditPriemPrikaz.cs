using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditPriemPrikaz : Form
    {
        private bool flagWork = false;
        private decimal pk_podr = -1;
        private decimal pk_dolzhn = -1;
        private decimal pk_prof = -1;
        private decimal tab = -1;
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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
            priem.ENDWORKDATE = dateTimePicker2.Value;
            priem.TESTPERIOD = numericUpDown4.Value;
            priem.CONDITIONS = textBox9.Text;
            // данные о новом месте работы
            priem.PK_PODR = pk_podr;
            priem.PK_JOB_POS = pk_dolzhn;
            priem.CHARACTER_WORK = model.CHARACTER_WORK.FirstOrDefault(cha => cha.PK_CHAR_WORK == 1);
            priem.PODRAZDELORG_PK_PODRAZDEL = 1;
            
            // сохраним изменения в бд
            model.SaveChanges();
            // закрываем форму
            Close();
        }


        private void buttonNewPlaceWork_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var dolzhn = model.JOB_POSITION.FirstOrDefault(d => d.NAME == textBoxNewDolzhn.Text);
            var prof = model.PROFESSION.FirstOrDefault(p => p.NAME == textBoxNewProf.Text);
            var podr = model.PODRAZDELORG.FirstOrDefault(po => po.NAME == comboBoxPodr.SelectedItem.ToString());
            if (dolzhn == null || prof == null || podr == null)
            {
                buttonConfirm.Enabled = false;
                return;
            }

            buttonConfirm.Enabled = true;
            pk_dolzhn = dolzhn.PK_JOB_POS;
            pk_podr = podr.PK_PODRAZDEL;
            pk_prof = prof.PK_PROF;

            var strStat = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == pk_dolzhn);
            if (strStat == null) return;
            numericUrerpDownTarifStavk.Value = Math.Round((decimal) strStat.TARIFF);
            numericUpDownNadbavk.Value = Math.Round((decimal) strStat.NADBAVKA1);
            flagWork = true;
        }
    }
}