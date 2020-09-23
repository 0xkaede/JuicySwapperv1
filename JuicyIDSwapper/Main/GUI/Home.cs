using AutoPathPaksFinder.Classes;
using DiscordRPC;
using JuicyIDSwapper.Main.GUI;
using JuicyIDSwapper.Panels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuicyIDSwapper
{
    public partial class Home : Form
    {
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("732652012826525706");
        private static string GetEpicDirectory() => Directory.Exists(@"C:\ProgramData\Epic") ? @"C:\ProgramData\Epic" : Directory.Exists(@"D:\ProgramData\Epic") ? @"D:\ProgramData\Epic" : Directory.Exists(@"E:\ProgramData\Epic") ? @"E:\ProgramData\Epic" : @"F:\ProgramData\Epic";
        private static bool DatFileExists() => File.Exists($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");

        public Home()
        {
            Paks();
            InitializeComponent();
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }
        void Paks()
        {
            if (DatFileExists())
            {
                string jsonData = File.ReadAllText($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");
                if (Utilities.IsValidJson(jsonData))
                {
                    JToken FortnitePath = JsonConvert.DeserializeObject<JToken>(jsonData);
                    if (FortnitePath != null)
                    {
                        JArray installationListArray = FortnitePath["InstallationList"].Value<JArray>();
                        if (installationListArray != null)
                        {
                            foreach (JToken FortnitePathReal in installationListArray)
                            {
                                if (string.Equals(FortnitePathReal["AppName"].Value<string>(), "Fortnite"))
                                {
                                    string path = $@"{FortnitePathReal["InstallLocation"].Value<string>()}\FortniteGame\Content\Paks";
                                    Properties.Settings.Default.pakPath = path;
                                    Properties.Settings.Default.Save();
                                    Properties.Settings.Default.Save();
                                }
                            }
                        }
                    }
                }
            }
        }
        public static string GetPaksFolder
        {
            get { return Properties.Settings.Default.pakPath; }
        }
        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void displayDashPanel_Click(object sender, EventArgs e) //Display DashPanel
        {
            Juicy.SetDiscordAction("In Dashboard");
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }

        private void displaySkinsPanel_Click(object sender, EventArgs e) //Display SkinsPanel
        {
            Juicy.SetDiscordLocation("Skins");
            if (!Wrapper.Controls.Contains(SkinsPanel.Instance))
            {
                Wrapper.Controls.Add(SkinsPanel.Instance);
                SkinsPanel.Instance.Dock = DockStyle.Fill;
                SkinsPanel.Instance.BringToFront();
            }
            else
                SkinsPanel.Instance.BringToFront();
        }  

        private void displayBackblingPanel_Click(object sender, EventArgs e) //Display BackblingsPanel
        {
            Juicy.SetDiscordLocation("Backblings");
            if (!Wrapper.Controls.Contains(BackblingsPanel.Instance))
            {
                Wrapper.Controls.Add(BackblingsPanel.Instance);
                BackblingsPanel.Instance.Dock = DockStyle.Fill;
                BackblingsPanel.Instance.BringToFront();
            }
            else
                BackblingsPanel.Instance.BringToFront();
        }

        private void displayEmotesPanel_Click(object sender, EventArgs e) //Display EmotesPanel
        {
            Juicy.SetDiscordLocation("Emotes");
            if (!Wrapper.Controls.Contains(EmotesPanel.Instance))
            {
                Wrapper.Controls.Add(EmotesPanel.Instance);
                EmotesPanel.Instance.Dock = DockStyle.Fill;
                EmotesPanel.Instance.BringToFront();
            }
            else
                EmotesPanel.Instance.BringToFront();
        }

        private void displayItemShop_Click(object sender, EventArgs e)
        {
            new ItemShop().ShowDialog();
        }

        private void displayCustomID_Click(object sender, EventArgs e)
        {
            new CustomID().ShowDialog();
        }

        private void displaySettings_Click(object sender, EventArgs e)
        {
            Juicy.SetDiscordLocation("Settings");
            new SettingsMenu().ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Environment.UserName;
            Juicy.SetDiscordAction("In Dashboard");
            Sidebar.Visible = false;
            Sidebar.Width = 68;
            SidebarWrapper.Width = 90;
            LineaSidebar.Width = 52;
            AnimacionSidebar.Show(Sidebar);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.openfortnite == true)
            {
                Environment.Exit(0);
            }
            else
            {
                SystemSounds.Beep.Play();
                DialogResult close = MessageBox.Show("Are you sure you want to close?", "Juicy ID Swapper", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (close == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
