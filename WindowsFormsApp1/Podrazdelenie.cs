using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ShtatnoeRasp;

namespace WindowsFormsApp1
{
    public partial class Podrazdelenie : Form
    {
        private Model1 model = new Model1();
        //Таблица должностей
        private List<StringJobPosition> stringJobPositions { get; set; }

        public PODRAZDELORG podrazdelorg;
        //Всего в подразделении по штату
        private int totalCount;
        //Всего заместителей
        private int totalZam;

        private StringJobPosition setDataInString(StringJobPosition str, int id ,string name, int kolEd, int kolZam, int tariff)
        {
            str.id = id;
            str.name = name;
            
            str.numSthatEd = kolEd;
            str.kolZam = kolZam;
            str.tariff = tariff;
            
            return str;
        }
        
        public Podrazdelenie()
        {
            InitializeComponent();
        }

        public Podrazdelenie(Shtatka shtatka)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedString = dataGridView1.SelectedRows[0].DataBoundItem as StringJobPosition;

            this.nameChoose.Text = selectedString.name;
            this.oklad.Text = selectedString.tariff.ToString();

        }

        private void AddNode(IQueryable<PODRAZDELORG> query,TreeNode parentNode, TreeNode childNode)
        {
            foreach (PODRAZDELORG podrazdelorg in query)
            {
                parentNode.Nodes.Add(podrazdelorg.NAME);
            }
        }
        
        private void Podrazdelenie_Load(object sender, EventArgs e)
        {
            this.Podrazdels.Nodes.Add(this.namePodrazdel.Text);
            TreeNode parentNode = Podrazdels.Nodes[0];
            IQueryable<PODRAZDELORG> query1 = model.PODRAZDELORG;
            query1 = query1.Where(podrazdelorg1 => podrazdelorg1.PK_PODRAZDEL_PK_PODRAZDEL == podrazdelorg.PK_PODRAZDEL);
            TreeNode node = new TreeNode(query1.FirstOrDefault().NAME);
            AddNode(query1,parentNode, node);
            totalCount = 0;
            totalZam = 0;
            stringJobPositions = new List<StringJobPosition>();
            IQueryable<STR_SHTAT_RASP> query = model.STR_SHTAT_RASP;
            query = query.Where(STR_SHTAT_RASP => STR_SHTAT_RASP.PODRAZDELORG.NAME == this.namePodrazdel.Text);
            Random random = new Random();
            foreach (STR_SHTAT_RASP jobPosition in query)
            {
                int rnd = random.Next(5);
                stringJobPositions.Add(setDataInString(new StringJobPosition(), Convert.ToInt32(jobPosition.PK_JOB_POS),
                    jobPosition.JOB_POSITION.NAME, Convert.ToInt32(jobPosition.COUNT_STUFF), rnd, Convert.ToInt32(jobPosition.TARIFF)));
                totalZam += rnd;
                totalCount += Convert.ToInt32(jobPosition.COUNT_STUFF);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stringJobPositions;
            dataGridView1.Columns[1].Width = 375;
            dataGridView1.Columns[2].Width = 95;
            dataGridView1.Columns[3].Width = 95;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["tariff"].Visible = false;

            this.totalCnt.Text = totalCount.ToString();
            this.totalZm.Text = totalZam.ToString();
        }
    }
}