using JuicyLauncher.Main.GUI;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicyLauncher.Panels
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

        private void swapperLaunchBtn_Click(object sender, System.EventArgs e)
        {
            if (!File.Exists ("Juicy Swapper.exe"))
            {
                new FileError().ShowDialog();
            }
            else
            {
                Process.Start("Juicy Swapper.exe");
                Environment.Exit(0);
            }
        }

        private void swapperUpdateBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("Juicy Swapper.exe"))
            {
                FileVersionInfo fileVersionInfo = null;
                try
                {
                    fileVersionInfo = FileVersionInfo.GetVersionInfo("Juicy Swapper.exe");
                }
                catch (Exception err)
                {
                    MessageBox.Show("ERROR: " + err);
                }
                string text = string.Format("{0}.{1}.{2}.{3}", new object[]
                {
                    fileVersionInfo.FileMajorPart,
                    fileVersionInfo.FileMinorPart,
                    fileVersionInfo.FileBuildPart,
                    fileVersionInfo.FilePrivatePart,
                });
                WebClient webClient = new WebClient();
                string ver = webClient.DownloadString("https://juicyswapper.xyz/api/version").ToString(); 
                if (text != ver)
                {
                    new Update().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Swapper up to date");
                }
            }
        }

        private void idLaunchBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Juicy ID Swapper.exe"))
            {
                new FileError().ShowDialog();
            }
            else
            {
                Process.Start("Juicy ID Swapper.exe");
                Environment.Exit(0);
            }
        }

        private void idUpdateBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("Juicy ID Swapper.exe"))
            {
                FileVersionInfo fileVersionInfo = null;
                try
                {
                    fileVersionInfo = FileVersionInfo.GetVersionInfo("Juicy ID Swapper.exe");
                }
                catch (Exception err)
                {
                    MessageBox.Show("ERROR: " + err);
                }
                string text = string.Format("{0}.{1}.{2}.{3}", new object[]
                {
                    fileVersionInfo.FileMajorPart,
                    fileVersionInfo.FileMinorPart,
                    fileVersionInfo.FileBuildPart,
                    fileVersionInfo.FilePrivatePart,
                });
                WebClient webClient = new WebClient();
                string ver = webClient.DownloadString("https://juicyswapper.xyz/api/id/version").ToString();
                if (text != ver)
                {
                    new Update().ShowDialog();
                }
                else
                {
                    MessageBox.Show("ID Swapper up to date");
                }
            }
        }
    }
}
