using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Komandirovki;
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
            string helpFileName = Directory.GetCurrentDirectory() + "\\help.chm";
            if (File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
            else
            {
                MessageBox.Show("Файл справки не найден. Ожидался по пути " + helpFileName);
            }
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
            SearchPersonCard ownedForm = new SearchPersonCard();
            ownedForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://v9gel.github.io/tabel/dist/index.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            print_report ownedForm = new print_report();
            ownedForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KomandirovkaForm ownedForm = new KomandirovkaForm();
            ownedForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainPagePrikaz ownedForm = new MainPagePrikaz();
            ownedForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Shtatka shtatnoeRaspisanie = new Shtatka();
            shtatnoeRaspisanie.Show();
        }

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}
    }
}