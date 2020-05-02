using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader rd = new StreamReader((Path.Combine(Directory.GetCurrentDirectory(), "report.txt"))))
            {
                richTextBox1.Text = await rd.ReadToEndAsync();
            }

        }

        private string result = "" ;

        private async void button2_Click(object sender, EventArgs e)
        {
            
            using (StreamReader rd = new StreamReader((Path.Combine(Directory.GetCurrentDirectory(), "report.txt"))))
            {
                result = await rd.ReadToEndAsync();
            }
            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}