using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Drawing2D;
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

        public int keyST;
        //Всего в подразделении по штату
        private int totalCount;
        //Всего заместителей
        private int totalZam;

        private StringJobPosition setDataInString(StringJobPosition str, int id ,string name, string dateCreate, string dateUprzad ,int kolEd, int kolZam, int tariff)
        {
            str.id = id;
            str.name = name;
            str.dateCreate = dateCreate;
            str.dateUprazd = dateUprzad;
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
        public Podrazdelenie(SearchPodrazdel podrazdel)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedString = dataGridView1.SelectedRows[0].DataBoundItem as StringJobPosition;

            this.nameChoose.Text = selectedString.name;
            this.oklad.Text = selectedString.tariff.ToString();
            this.dateCreateT.Text = selectedString.dateCreate;
            this.dateUprazdT.Text = selectedString.dateUprazd;
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
            TreeNode node;
            if (query1.Count() != 0)
            {
                node = new TreeNode(query1.FirstOrDefault().NAME);
                AddNode(query1, parentNode, node);
            }

            totalCount = 0;
            totalZam = 0;
            stringJobPositions = new List<StringJobPosition>();
            IQueryable<STR_SHTAT_RASP> query = model.STR_SHTAT_RASP;
            query = query.Where(STR_SHTAT_RASP => STR_SHTAT_RASP.PODRAZDELORG.NAME == this.namePodrazdel.Text);
            query = query.Where(rasp => rasp.SHTAT_RASP_PK_SHTAT_RASP == keyST);
            Random random = new Random();
            foreach (STR_SHTAT_RASP jobPosition in query)
            {
                int rnd = random.Next(2);
                stringJobPositions.Add(setDataInString(new StringJobPosition(), Convert.ToInt32(jobPosition.PK_JOB_POS),
                    jobPosition.JOB_POSITION.NAME, jobPosition.JOB_POSITION.DATECREATE.ToString(),jobPosition.JOB_POSITION.DATEUPRAZD.ToString(),Convert.ToInt32(jobPosition.COUNT_STUFF), rnd, Convert.ToInt32(jobPosition.TARIFF)));
                totalZam += rnd;
                totalCount += Convert.ToInt32(jobPosition.COUNT_STUFF);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stringJobPositions;
            dataGridView1.Columns[1].Width = 255;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 45;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["tariff"].Visible = false;

            this.totalCnt.Text = totalCount.ToString();
            this.totalZm.Text = totalZam.ToString();
        }

        private void Podrazdels_AfterSelect(object sender, TreeViewEventArgs e)
        {
            stringJobPositions = new List<StringJobPosition>();
            IQueryable<STR_SHTAT_RASP> jobs = model.STR_SHTAT_RASP;
            jobs = jobs.Where(rasp => rasp.PODRAZDELORG.NAME == Podrazdels.SelectedNode.Text);
            jobs = jobs.Where(rasp => rasp.SHTAT_RASP_PK_SHTAT_RASP == keyST);
            Random random = new Random();
            totalCount = 0;
            totalZam = 0;
            foreach (STR_SHTAT_RASP jobPosition in jobs)
            {
                int rnd = random.Next(5);
                stringJobPositions.Add(setDataInString(new StringJobPosition(), Convert.ToInt32(jobPosition.PK_JOB_POS),
                    jobPosition.JOB_POSITION.NAME, jobPosition.JOB_POSITION.DATECREATE.ToString(),jobPosition.JOB_POSITION.DATEUPRAZD.ToString(),Convert.ToInt32(jobPosition.COUNT_STUFF), rnd, Convert.ToInt32(jobPosition.TARIFF)));
                totalZam += rnd;
                totalCount += Convert.ToInt32(jobPosition.COUNT_STUFF);
            }
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stringJobPositions;
            dataGridView1.Columns[1].Width = 255;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 45;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns["id"].Visible = false;
            this.totalCnt.Text = totalCount.ToString();
            this.totalZm.Text = totalZam.ToString();
        }
    }
}