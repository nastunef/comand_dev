using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class AddPodrazdel : Form
    {
        private  Model1 model = new Model1();
        public AddPodrazdel()
        {
            InitializeComponent();
        }

        private void AddPodrazdel_Load(object sender, EventArgs e)
        {
            IQueryable<PODRAZDELORG> podrazdelorgs = model.PODRAZDELORG;
            foreach (PODRAZDELORG podrazdelorg in podrazdelorgs)
            {
                mainPodrazdel.Items.Add(podrazdelorg);
            }
        }
    }
}