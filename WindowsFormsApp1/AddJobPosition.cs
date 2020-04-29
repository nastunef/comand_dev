using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShtatnoeRasp;

namespace WindowsFormsApp1
{
    public partial class AddJobPosition : Form
    {
        private static Model1 model = new Model1();
        
        private Dictionary<string, int> job_pk;
        private int countJob;
        public AddJobPosition()
        {
            InitializeComponent();
        }

        public AddJobPosition(Shtatka shtatka, int count, Dictionary<string,int> job_pk)
        {
            InitializeComponent();
            this.countJob = count;
            this.job_pk = job_pk;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            JOB_POSITION jobPosition = new JOB_POSITION();
            jobPosition.PK_JOB_POS = countJob;
            jobPosition.NAME = NameJobPosition.Text;
            jobPosition.DATECREATE = dateCreate.Value;
            jobPosition.DATEUPRAZD = dateUprazd.Value;
            jobPosition.CIPHER = codeJob.Text;
            model.JOB_POSITION.Add(jobPosition);
            model.SaveChanges();
            job_pk.Add(jobPosition.NAME,Convert.ToInt32(jobPosition.PK_JOB_POS));
            MessageBox.Show("Доабвлено", "", MessageBoxButtons.OK);
            this.Close();
        }
    }
}