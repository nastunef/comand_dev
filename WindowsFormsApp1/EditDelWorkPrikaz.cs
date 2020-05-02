using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditDelWorkPrikaz : Form
    {
    private long idPrikaz;
        public EditDelWorkPrikaz()
        {
            InitializeComponent();
        }
        
        public EditDelWorkPrikaz(long id)
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
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var prikaz = model.PRIKAZ.FirstOrDefault(p => p.PK_PRIKAZ == idPrikaz);
            if (prikaz == null) return;
            prikaz.OKPO = textBox13.Text;
            prikaz.OKUD = "0301001";
            prikaz.NUMDOC = textBox14.Text;
            prikaz.CREATEDATE = dateTimePicker1.Value;
            prikaz.OUR_ORG = model.OUR_ORG.FirstOrDefault(ourOrg => ourOrg.NAME == textBox11.Text);
            prikaz.TYPE_PRIKAZ = model.TYPE_PRIKAZ.FirstOrDefault(type => type.PK_TYPE == 3);
            model.SaveChanges();

            var uval = model.UVAL.FirstOrDefault(u => u.PK_PRIKAZ == idPrikaz);
            uval.REASOM = textBox8.Text;
            uval.ENDWORKDOGOVORDATE = dateTimePicker4.Value;
            uval.UVALDATE = dateTimePicker2.Value;

            uval.PRIKAZ = model.PRIKAZ.FirstOrDefault(prr => prr.PK_PRIKAZ == idPrikaz);
            // TODO
            uval.PODRAZDELORG = model.PODRAZDELORG.FirstOrDefault(podr => podr.PK_PODRAZDEL == 1);
            uval.JOB_POSITION = model.JOB_POSITION.FirstOrDefault(job => job.PK_JOB_POS == 1);
            model.SaveChanges();
            // закрываем форму
            Close();
        }
    }
}