using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicyIDSwapper.Panels
{
    public partial class DashPanel : UserControl
    {
        private static DashPanel _instance;      
        public static DashPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashPanel();
                return _instance;
            }
        }
        public DashPanel()
        {
            InitializeComponent();
            bunifuFlatButton1.Text = "    " + new WebClient().DownloadString("https://juicyswapper.xyz/api/name") + " - Developer";
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://juicyswapper.xyz");
        }

        private void DashPanel_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string imageLocation = webClient.DownloadString("https://juicyswapper.xyz/api/id/news/image");
            pictureBox2.ImageLocation = imageLocation;
            label5.Text = $"Current Version: v{Application.ProductVersion}";
            label3.Text = new WebClient().DownloadString("https://juicyswapper.xyz/api/id/news/text");
            label2.Text = new WebClient().DownloadString("https://juicyswapper.xyz/api/id/changelog");
        }
    }
}
