using JuicyIDSwapper.Main.GUI;
using System;
using System.Windows.Forms;

namespace JuicyIDSwapper.Panels
{
    public partial class SkinsPanelScroll : UserControl
    {
        private static SkinsPanelScroll _instance;
        public static SkinsPanelScroll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinsPanelScroll();
                return _instance;
            }
        }
        public SkinsPanelScroll()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new RenegadeRaider().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new BlackKnight().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new AerialAssaultTrooper().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new GhoulTrooper().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new SkullTrooper().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new HonorGuard().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Ikonik().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Galaxy().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new Glow().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new ShadowArchetype().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            new DarkVertex().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new Wonder().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new StealthReflex().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new NiteGunner().ShowDialog();
        }
    }
}
