using System;
using System.Diagnostics;
using System.Windows.Forms;
using ShtatnoeRasp;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ownedForm = new About();
            ownedForm.Show();
        }
        
        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions ownedForm = new Instructions();
            ownedForm.Show();
        }

        private void вопросыИПредложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questions ownedForm = new Questions();
            ownedForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PersonalCard ownedForm = new PersonalCard();
            ownedForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tabelu ownedForm = new Tabelu();
            ownedForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabelu ownedForm = new Tabelu();
            Process.Start("https://v9gel.github.io/tabel/dist/index.html");
            // ownedForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports ownedForm = new Reports();
            ownedForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ownedForm = new Form();
            ownedForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tabelu ownedForm = new Tabelu();
            ownedForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Shtatka shtatnoeRaspisanie = new Shtatka();
            shtatnoeRaspisanie.Show();
        }
    }
}