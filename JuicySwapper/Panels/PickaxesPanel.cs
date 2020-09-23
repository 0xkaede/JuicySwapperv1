using DiscordRPC;
using JuicySwapper.Main.Item.Pickaxes;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class PickaxesPanel : UserControl
    {
        private static PickaxesPanel _instance;      
        public static PickaxesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PickaxesPanel();
                return _instance;
            }
        }
        public PickaxesPanel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new ACDC().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new RaidersRevenge().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new MerryMintAxe().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new DualRaiders().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new PartyAnimal().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new StarWand().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Reaper().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new StellarAxe().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new OGDefault().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new CandyAxe().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            new StuddedAxe().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new PinkFlamingo().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new HarleyHitter().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new TrustyNo2().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            new Spiky().ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new WidowsBite().ShowDialog();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            new IceBreaker().ShowDialog();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            new Driver().ShowDialog();
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not added yet!");
            //new PsiBlade().ShowDialog();
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            new AxeOfChampions().ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            new Vision().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new Crowbar().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new Bootstraps().ShowDialog();
        }
    }
}
