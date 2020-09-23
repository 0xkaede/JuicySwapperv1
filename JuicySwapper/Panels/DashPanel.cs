using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
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
            bunifuFlatButton1.Text = "    " + "kaede - Developer";
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
            label5.Text = $"Current Version: v{Application.ProductVersion}";
            label3.Text = "news";
            label2.Text = "changelog";
        }
    }
}
