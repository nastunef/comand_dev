using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchPodrazdel : Form
    {
        private Model1 model = new Model1();
        public SearchPodrazdel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryable<PODRAZDELORG> query = model.PODRAZDELORG;
            query = query.Where(podrazdelorg => podrazdelorg.NAME == textBox1.Text);
            if (query.Count() != 0)
            {
                string dataCreate = "";
                Podrazdelenie podrazdelenie = new Podrazdelenie(this);
                podrazdelenie.namePodrazdel.Text = textBox1.Text;
                foreach (PODRAZDELORG podrazdelorg in query)
                {
                    podrazdelenie.podrazdelorg = podrazdelorg;
                    dataCreate = podrazdelorg.DATECREATE.ToString();
                }
                podrazdelenie.dataCreate.Text = dataCreate;
                podrazdelenie.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данного подразделения несуществует");
            }
        }
    }
}