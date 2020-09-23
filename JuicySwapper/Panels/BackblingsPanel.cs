using JuicySwapper.Main.GUI;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class BackblingsPanel : UserControl
    {
        private static BackblingsPanel _instance;      
        public static BackblingsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BackblingsPanel();
                return _instance;
            }
        }
        public BackblingsPanel()
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
            new BypassWarning().ShowDialog();
            new BackupPlan().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new BlackShield().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new DiscoBall().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new FallenWings().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new FireVortex().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new FlameSigil().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new GalacticDisc().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new GalaxyWings().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new GhostPortal().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new GlimmeringCloak().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            new IllusionRune().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Insignia().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new RainbowClover().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new BattleShroud().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Scaly().ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new SixString().ShowDialog();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new SpectralSpine().ShowDialog();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Stitches().ShowDialog();
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new VenturionCape().ShowDialog();
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new AutumnsMantle().ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new CovenCape().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new CrestedCape().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new CuddleBow().ShowDialog();
        }

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Dismal().ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new EnduringCape().ShowDialog();
        }

        private void bunifuImageButton26_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new RoyaleShield().ShowDialog();
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Wolfpack().ShowDialog();
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            new LoveWings().ShowDialog();
        }
    }
}
