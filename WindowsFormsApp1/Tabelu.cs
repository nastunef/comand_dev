using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WindowsFormsApp1
{
    public partial class Tabelu : Form
    {
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            Cef.EnableHighDPISupport();
            browser = new ChromiumWebBrowser("http://e328e289.ngrok.io/#/tabel/1");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        public Tabelu()
        {
            InitializeComponent();
            InitBrowser();
        }
    }
}