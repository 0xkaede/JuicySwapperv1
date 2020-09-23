using DiscordRPC;
using JuicyLauncher.Main.GUI;
using JuicyLauncher.Panels;
using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace JuicyLauncher
{
    public partial class Home : Form
    {
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("704324460291031047");

        public Home()
        {
            InitializeComponent();
            Juicy.SetDiscordLocation("In the Launcher");
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e) //Display DashPanel
        {
            if (!Wrapper.Controls.Contains(DashPanel.Instance))
            {
                Wrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Environment.UserName;
            Sidebar.Visible = false;
            Sidebar.Width = 68;
            SidebarWrapper.Width = 90;
            LineaSidebar.Width = 52;
            AnimacionSidebar.Show(Sidebar);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult close = MessageBox.Show("Are you sure you want to close?", "Juicy Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            new Uninstall().ShowDialog();
        }
    }
}
