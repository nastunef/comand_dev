using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komandirovki
{
    public partial class KomandirovkaForm : Form
    {
        public KomandirovkaForm()
        {
            InitializeComponent();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            SearchWorkerForm searchWorkerForm = new SearchWorkerForm();
            searchWorkerForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            AddPlaceKomandForm addPlaceKomandForm = new AddPlaceKomandForm();
            addPlaceKomandForm.Show();
        }
    }

}