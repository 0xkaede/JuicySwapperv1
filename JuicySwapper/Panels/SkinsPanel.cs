using JuicySwapper.Main.GUI;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class SkinsPanel : UserControl
    {
        private static SkinsPanel _instance;      
        public static SkinsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinsPanel();
                return _instance;
            }
        }
        public SkinsPanel()
        {
            InitializeComponent();
            bunifuFlatButton1.Text = "    " + "kaede - Developer";
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SkinsPanel_Load(object sender, EventArgs e)
        {
            if (!Wrapper.Controls.Contains(SkinsPanelScroll.Instance))
            {
                Wrapper.Controls.Add(SkinsPanelScroll.Instance);
                SkinsPanelScroll.Instance.Dock = DockStyle.Fill;
                SkinsPanelScroll.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }
    }
}
