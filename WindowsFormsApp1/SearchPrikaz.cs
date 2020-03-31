using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchPrikaz : Form
    {
        public SearchPrikaz()
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
            IQueryable<PRIKAZ> selectMens = model.PRIKAZ;
            if (firstname != "")
                selectMens = selectMens.Where
                    (men => men.PERSONCARD.NAME == firstname);
            if (fullname != "") selectMens = selectMens.Where
                (men => men.PERSONCARD.SURNAME == fullname);
            if (otchestvo != "") selectMens = selectMens.Where
                (men => men.PERSONCARD.MIDDLENAME == otchestvo);
            selectMens.FirstOrDefault();
            if (selectMens == null) 
                return;

            selectMens.ToArray();
            foreach (var item in selectMens)
            {
                bool isProject = false;
                if (item.ISPROJECT == "1") 
                    isProject = true;
                dataGridView_family.Rows.Add(item.PERSONCARD.SURNAME + " " + item.PERSONCARD.NAME + " " + item.PERSONCARD.MIDDLENAME,
                    item.CREATEDATE,  item.TYPE_PRIKAZ.NAME, isProject);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}