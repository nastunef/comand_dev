using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace Komandirovki
{
    public partial class SearchWorkerForm : Form
    {
        private Model1 model;
        private KomandirovkaForm komandirovkaForm;
        private IList<PERSONCARD> result;
        public SearchWorkerForm()
        {
            InitializeComponent();
        }

        public SearchWorkerForm(Model1 model, KomandirovkaForm komandirovkaForm)
        {
            InitializeComponent();
            this.model = model;
            this.komandirovkaForm = komandirovkaForm;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var surname = SurNameTextBox.Text;
            var name = NameTextBox.Text;
            var midname = MidNameTextBox.Text;
            var tabNum = TabNumTextBox.Text;
            if(string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(midname) && string.IsNullOrWhiteSpace(tabNum))
            {
                MyMsgBox.showError("Заполните хотя бы 1 поле");
                return;
            }

            IQueryable<PERSONCARD> query = model.PERSONCARD;
            if (!string.IsNullOrWhiteSpace(surname))
                query = query.Where(worker => worker.SURNAME == surname);
            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(worker => worker.NAME == name);
            if (!string.IsNullOrWhiteSpace(midname))
                query = query.Where(worker => worker.MIDDLENAME == midname);
            if (!string.IsNullOrWhiteSpace(tabNum)) {
                int tabNumInt;
                try {
                    tabNumInt = int.Parse(tabNum); 
                }catch(Exception expr)
                {
                    MyMsgBox.showError("Табельный номер должен содержать только числа");
                    Console.WriteLine(expr.Message);
                    return;
                }
                query = query.Where(worker => worker.TABEL_NUM == tabNumInt);
            }

            if(query.Count() == 0)
            {
                MyMsgBox.showInfo("Ничего не найдено");
                return;
            }
            foreach(PERSONCARD worker in query)
            {
                result.Add(worker);
                pERSONCARDBindingSource.Add(worker);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if(rows.Count == 0)
            {
                MyMsgBox.showError("Ничего не выделено");
            }
            List<PERSONCARD> selected = new List<PERSONCARD>();
            foreach(DataGridViewRow row in rows)
            {
                selected.Add(result[row.Index]);
            }

            komandirovkaForm.SetWorkers(result);
            MyMsgBox.showInfo("Добавлено!");
        }
    }
}
