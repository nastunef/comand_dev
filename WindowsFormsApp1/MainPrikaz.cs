using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPrikaz : Form
    {
        public MainPrikaz()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_family.Rows.Clear();
            string firstname = this.firstname.Text;
            string fullname = this.fullname.Text;
            string otchestvo = this.otchestvo.Text;
            Model1 model = new Model1();
            var selectMens = model.PERSONCARD.Where
                (men => men.SURNAME == fullname && men.NAME == firstname && men.MIDDLENAME == otchestvo).ToArray();
            if (selectMens == null) 
                return;
            foreach (var item in selectMens)
            {
                dataGridView_family.Rows.Add(item.SURNAME + " " + item.NAME + " " + item.MIDDLENAME,
                    item.BIRTHDATE, item.TABEL_NUM);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView_family.Rows.Count == 0)
                return;
            int selRowNum = dataGridView_family.SelectedCells[0].RowIndex;
            decimal tabNumber = (decimal) dataGridView_family.Rows[selRowNum].Cells[2].Value;
            
            PriemWorkPrikaz priemWorkPrikaz = new PriemWorkPrikaz(tabNumber);
            priemWorkPrikaz.Show();
        }
    }
}