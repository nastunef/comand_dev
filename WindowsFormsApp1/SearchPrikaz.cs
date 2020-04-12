using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchPrikaz : Form
    {
        public SearchPrikaz()
        {
            InitializeComponent();
            _list = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_family.Rows.Clear();
            _list.Clear();
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
            string isProjectt = "0";
            if (checkBox_Confirm.Checked == true) isProjectt = "1";
            selectMens = selectMens.Where
                    (men => men.ISPROJECT == isProjectt);
            DateTime dateOt = new DateTime(dateTimePickerOt.Value.Year, 
                dateTimePickerOt.Value.Month, 
                dateTimePickerOt.Value.Day, 0, 0, 0, 0);
            DateTime dateDo = dateTimePickerDo.Value;

            selectMens = selectMens.Where(men =>
                men.CREATEDATE.Value.CompareTo(dateOt) >= 0 &&
                men.CREATEDATE.Value.CompareTo(dateDo) <= 0);
            
            selectMens.FirstOrDefault();
            if (selectMens == null) 
                return;

            selectMens.ToArray();
            foreach (var item in selectMens)
            {
                bool isProject = false;
                if (item.ISPROJECT == "1") 
                    isProject = true;
                if ((checkBoxPriem.Checked && item.PK_TYPE_PRIKAZ == 1) ||
                    (checkBoxKomand.Checked && item.PK_TYPE_PRIKAZ == 2) ||
                    (checkBoxDelWork.Checked && item.PK_TYPE_PRIKAZ == 3))
                {
                    dataGridView_family.Rows.Add(item.PERSONCARD.SURNAME + " " + item.PERSONCARD.NAME + " " + item.PERSONCARD.MIDDLENAME,
                        item.CREATEDATE,  item.TYPE_PRIKAZ.NAME, isProject);
                    _list.Add(item.PK_PRIKAZ);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView_family.Rows.Count == 0)
                return;
            int selRowNum = dataGridView_family.SelectedCells[0].RowIndex;
            Model1 model = new Model1();
            string pkString = _list[selRowNum].ToString();
            int pkInt = 1;
            Int32.TryParse(pkString, out pkInt);
            var selectedPrikaz = model.PRIKAZ.FirstOrDefault(prikaz =>
                prikaz.PK_PRIKAZ == pkInt);
            if (selectedPrikaz == null) return;

            if (selectedPrikaz.TYPE_PRIKAZ.PK_TYPE == 1)
            {
                ReadPriemPrikaz readPriemPrikaz = new ReadPriemPrikaz(selectedPrikaz.PK_PRIKAZ);
                readPriemPrikaz.Show();
            }
            
            if (selectedPrikaz.TYPE_PRIKAZ.PK_TYPE == 2)
            {
                
            }
            
            if (selectedPrikaz.TYPE_PRIKAZ.PK_TYPE == 3)
            {
                ReadDelWorkPrikaz readDelWorkPrikaz = new ReadDelWorkPrikaz(selectedPrikaz.PK_PRIKAZ);
                readDelWorkPrikaz.Show();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}