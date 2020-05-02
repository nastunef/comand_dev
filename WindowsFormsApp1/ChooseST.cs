using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ShtatnoeRasp;

namespace WindowsFormsApp1
{
    public partial class ChooseST : Form
    {
        private  Model1 model = new Model1();
        private Shtatka shtatka;
        public ChooseST()
        {
            InitializeComponent();
        }

        public ChooseST(Shtatka shtatka)
        {
            this.shtatka = shtatka;
            InitializeComponent();
        }
        
        private void ChooseST_Load(object sender, EventArgs e)
        {
            IQueryable<SHTAT_RASP> rasps = model.SHTAT_RASP;
            foreach (SHTAT_RASP shtat in rasps)
            {
                numerusST.Items.Add(shtat.number);
            }
            
        }

        private void okey_Click(object sender, EventArgs e)
        {
            this.Close();
            shtatka.numDocFromChoose = Convert.ToInt32(numerusST.SelectedItem.ToString());
            shtatka.setStrginRasps();
        }
        
    }
}