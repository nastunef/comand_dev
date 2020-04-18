using System;
using System.Linq;
using System.Windows.Forms;
using Komandirovki;

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
            IQueryable<PERSONCARD> selectMens = model.PERSONCARD;
            if (firstname != "")
                selectMens = selectMens.Where
                    (men => men.NAME == firstname);
            if (fullname != "") selectMens = selectMens.Where
                (men => men.SURNAME == fullname);
            if (otchestvo != "") selectMens = selectMens.Where
                (men => men.MIDDLENAME == otchestvo);
            selectMens.FirstOrDefault();
            if (selectMens == null) 
                return;
            selectMens.ToArray();
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
            
            if (priem.Checked == true)
            {
                PriemWorkPrikaz priemWorkPrikaz = new PriemWorkPrikaz(tabNumber);
                priemWorkPrikaz.Show();
            }

            if (deletework.Checked == true)
            {
                DelWorkPrikaz delWorkPrikaz = new DelWorkPrikaz(tabNumber);
                delWorkPrikaz.Show();
            }
            
            if (comandirovka.Checked == true)
            {
                KomandirovkaForm form = new KomandirovkaForm();
                form.SetOneWorkerByTabelNumber(tabNumber);
                form.Show();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}