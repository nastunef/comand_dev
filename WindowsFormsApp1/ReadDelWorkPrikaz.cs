using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadDelWorkPrikaz : Form
    {
       private long idPrikaz;
        public ReadDelWorkPrikaz()
        {
            InitializeComponent();
        }
        
        public ReadDelWorkPrikaz(long id)
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
            textBox12.Text = "0301001";

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

            var uval = model.UVAL.FirstOrDefault(u => u.PK_PRIKAZ == idPrikaz);
            dateTimePicker4.Value = uval.ENDWORKDOGOVORDATE.Value; 
            dateTimePicker2.Value = uval.UVALDATE.Value;
            textBox8.Text = uval.REASOM;
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
            var delWork = model.UVAL.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (delWork != null) model.UVAL.Remove(model.UVAL.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (delWork != null) model.PRIKAZ.Remove(model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            model.SaveChanges();
            // закрываем форму
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //TODO
            
            
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (prikaz == null ) return;
            prikaz.ISPROJECT = "1";
            model.SaveChanges();
            // закрываем форму
            Close();
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var priem = model.UVAL.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.UVAL.Remove(model.UVAL.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (priem != null) model.PRIKAZ.Remove(model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz));
            model.SaveChanges();
            // закрываем форму
            Close();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            EditDelWorkPrikaz  editDelWorkPrikaz = new EditDelWorkPrikaz(idPrikaz);
            editDelWorkPrikaz.Show();
        }
    }
}