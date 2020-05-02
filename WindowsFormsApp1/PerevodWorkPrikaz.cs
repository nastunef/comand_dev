using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PerevodWorkPrikaz : Form
    {
        private bool flagWork = false;
        private decimal pk_podr = -1;
        private decimal pk_dolzhn = -1;
        private decimal pk_prof = -1;
        
        public PerevodWorkPrikaz()
        {
            InitializeComponent();
        }

        public PerevodWorkPrikaz(decimal tabNumber)
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
            comboBoxVid.Text = comboBoxVid.Items[0].ToString();
            var prikaz = model.PRIKAZ.FirstOrDefault();
            button1.Enabled = false;
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

            if (selectedMen.JOB_POSITION != null)
            {
                var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == selectedMen.JOB_POSITION.PK_JOB_POS);
                if (strStat == null) return;
                numericUrerpDownTarifStavk.Value = (decimal) strStat.TARIFF;
                numericUpDownNadbavk.Value = (decimal) strStat.NADBAVKA1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                comboBoxVid.Text = comboBoxVid.Items[1].ToString();
            }
            else
            {
                dateTimePicker2.Enabled = false;
                comboBoxVid.Text = comboBoxVid.Items[0].ToString();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flagWork)
            {
                Model1 model = new Model1();
                long newId = 0;
                // добавим сущность приказ в бд
                newId = model.PRIKAZ.Max(pr => pr.PK_PRIKAZ) + 1;
                var newPrikaz = new PRIKAZ();
                newPrikaz.PK_PRIKAZ = newId;
                newPrikaz.OKPO = textBox13.Text;
                newPrikaz.OKUD = "0301004";
                newPrikaz.NUMDOC = textBox14.Text;
                newPrikaz.CREATEDATE = dateTimePicker1.Value;
                newPrikaz.PERSONCARD = model.PERSONCARD.FirstOrDefault(men => men.PK_PERSONCARD == idSelectMen);
                newPrikaz.OUR_ORG = model.OUR_ORG.FirstOrDefault(ourOrg => ourOrg.NAME == textBox11.Text);
                newPrikaz.ISPROJECT = "0";
                newPrikaz.PK_TYPE_PRIKAZ = 4;
                newPrikaz.TYPE_PRIKAZ = model.TYPE_PRIKAZ.FirstOrDefault(type => type.PK_TYPE == 4);
                model.PRIKAZ.Add(newPrikaz);
                model.SaveChanges();
            
                // добавим сущность Перевод
                long newIdPerevod = 0;
                // добавим сущность приказ в бд
                newIdPerevod = (model.PEREVOD.Max(pr => pr.PK_PEREVOD) + 1);
                var newPerevod = new PEREVOD();
                newPerevod.PK_PEREVOD = newIdPerevod;
                newPerevod.STARTWORKDATE = dateTimePicker4.Value;
                newPerevod.REASON = textBoxPrichinaPerevoda.Text;
                newPerevod.PERSONCARD = model.PERSONCARD.FirstOrDefault(men => men.PK_PERSONCARD == idSelectMen);
                if (checkBox1.Checked) newPerevod.ENDWORKDATE = dateTimePicker2.Value;
                newPerevod.PRIKAZ = model.PRIKAZ.FirstOrDefault(prr => prr.PK_PRIKAZ == newId);

                newPerevod.TYPE = comboBoxVid.SelectedItem.ToString();
                newPerevod.REASON = textBoxPrichinaPerevoda.Text;
                
                // данные о старом месте работы
                var dolzhn = model.JOB_POSITION.FirstOrDefault(d => d.NAME == textBox6.Text);
                var podr = model.PODRAZDELORG.FirstOrDefault(po => po.NAME == textBox5.Text);
                var prof = model.PROFESSION.FirstOrDefault(p => p.NAME == textBox7.Text);
                newPerevod.PK_OLD_JOB_POS = dolzhn.PK_JOB_POS;
                newPerevod.PK_OLD_JOB_POS = podr.PK_PODRAZDEL;
                newPerevod.PK_OLD_PROF = prof.PK_PROF;
                
                // данные о новом месте работы
                newPerevod.PK_NEW_PODRAZDEL = pk_podr;
                newPerevod.PK_NEW_JOB_POS = pk_dolzhn;
                newPerevod.PK_NEW_PROF = pk_prof;
                //
                model.PEREVOD.Add(newPerevod);
                model.SaveChanges();
            
                // закрываем форму
                Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
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
                button1.Enabled = false;
                return;
            }
            button1.Enabled = true;
            pk_dolzhn = dolzhn.PK_JOB_POS;
            pk_podr = podr.PK_PODRAZDEL;
            pk_prof = prof.PK_PROF;
            
            var strStat  = model.STR_SHTAT_RASP.FirstOrDefault(stat => stat.PK_JOB_POS == pk_dolzhn);
            if (strStat == null) return;
            numericUrerpDownTarifStavk.Value = Math.Round((decimal)strStat.TARIFF);
            numericUpDownNadbavk.Value = Math.Round((decimal) strStat.NADBAVKA1);
            flagWork = true;
        }
    }
}