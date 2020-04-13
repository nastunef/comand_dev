using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPagePrikaz : Form
    {
        public MainPagePrikaz()
        {
            InitializeComponent();
        }

        private void createPrikaz_Click(object sender, EventArgs e)
        {
            _mainPrikaz = new MainPrikaz();
            _mainPrikaz.Show();
        }

        private void searchPrikaz_Click(object sender, EventArgs e)
        {
            _searchPrikaz = new SearchPrikaz();
            _searchPrikaz.Show();
        }
    }
}