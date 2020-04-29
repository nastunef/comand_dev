using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ShtatnoeRasp;

namespace WindowsFormsApp1
{
    public partial class AddPodrazdel : Form
    {
        private Model1 model = new Model1();
        private Dictionary<string, int> podrazd_pk;

        
        
        private int countPodrazdels;
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

        public AddPodrazdel(Shtatka shtatka, Dictionary<string, int> podrazd_pk, int count)
        {
            InitializeComponent();
            this.podrazd_pk = podrazd_pk;
            this.countPodrazdels = count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codePodrazdel.Text.Equals(""))
            {
                MessageBox.Show("Заполните код подразделения");
            }
            else
            {
                PODRAZDELORG podrazdelorg = new PODRAZDELORG();
                podrazdelorg.PK_PODRAZDEL = countPodrazdels;
                podrazdelorg.CODE = codePodrazdel.Text;
                podrazdelorg.DATECREATE = dateCreate.Value;
                podrazdelorg.DATEUPRAZD = dateUprazd.Value;
                podrazdelorg.NAME = NamePodrazdel.Text;
                podrazdelorg.PK_PODRAZDEL_PK_PODRAZDEL = podrazd_pk[mainPodrazdel.SelectedItem.ToString()];
                model.PODRAZDELORG.Add(podrazdelorg);
                model.SaveChanges();
                podrazd_pk.Add(podrazdelorg.NAME, Convert.ToInt32(podrazdelorg.PK_PODRAZDEL));
                MessageBox.Show("Добавлено", "", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}