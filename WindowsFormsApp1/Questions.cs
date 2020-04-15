using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromUser = richTextBox1.Text; 
            string uemail = "pi62groupp@gmail.com"; 
            string upassword = "Parolparol3214"; 
            string myEmail = "ilya.lebedev.98@mail.ru";
            MailAddress from = new MailAddress(uemail);
            MailAddress to = new MailAddress(myEmail);
            MailMessage message = new MailMessage(from, to) 
            
            {
                Subject = "Пришел отзыв!",
                IsBodyHtml = false,
                Body = $"{fromUser}"
            };
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(uemail, upassword),
                EnableSsl = true
            };
            smtp.Send(message);
            MessageBox.Show("Сообщение успешно отправлено. Спасибо!");
            Close();

        }
        
    }
}


