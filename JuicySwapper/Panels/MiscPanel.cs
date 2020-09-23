using JuicySwapper.Main.GUI;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class MiscPanel : UserControl
    {
        private static MiscPanel _instance;      
        public static MiscPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MiscPanel();
                return _instance;
            }
        }
        public MiscPanel()
        {
            InitializeComponent();
            bunifuFlatButton1.Text = "    " + "kaede - Developer";
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new ScenarioMusic().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new ToosieMusic().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new SuperOGMusic().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new JuicyEAC1().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new JuicyEAC2().ShowDialog();
        }
    }
}
