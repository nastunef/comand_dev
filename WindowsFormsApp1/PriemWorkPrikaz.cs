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
            initData();
        }
        
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelWorkPrikaz deleteWork = new DelWorkPrikaz();
            deleteWork.Show();
        }

        private void initData()
        {
            
            Model1 model = new Model1();
            var org = model.OUR_ORG.FirstOrDefault(c => c.PK_OUR_ORG == 1);
            if (org == null) 
                return;
            string numberDoc = "12345678";
            var prikaz = model.PRIKAZ.FirstOrDefault();
            if (prikaz != null)
            {
                numberDoc = prikaz.NUMDOC;
                int numberDocInt = 0;
                Int32.TryParse(numberDoc, out numberDocInt);
                numberDocInt++;
                numberDoc = numberDocInt.ToString();
            }
            textBox11.Text = org.NAME;
            textBox12.Text = "0301001";
            textBox13.Text = org.OKPO;
            textBox14.Text = numberDoc;
            
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
    }
}