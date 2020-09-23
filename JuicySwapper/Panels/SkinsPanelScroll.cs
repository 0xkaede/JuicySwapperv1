using JuicySwapper.Main.GUI;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Panels
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
            new BypassWarning().ShowDialog();
            new RenegadeRaider().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new GhoulOG().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new RedNosed().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Sparkplug().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Ruby().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Bracer().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new AutumnQueen().ShowDialog();
        }
        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Punchy().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Bolt().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Hush().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Doublecross().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new SkullRanger().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Birdie().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            new StealthReflex().ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new BlackKnight().ShowDialog();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            new Wonder().ShowDialog();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new AerialAssault().ShowDialog();
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Scarlet Commander", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new ScarletCommander().ShowDialog();
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            new Glow().ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            new Ikonik().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new Mezmer().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new RenegadeRaiderC().ShowDialog();
        }

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            new SparkleSpecialist().ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            new Zadie().ShowDialog();
        }

        private void bunifuImageButton26_Click(object sender, EventArgs e)
        {
            new ScarletDefender().ShowDialog();
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            new Inferno().ShowDialog();
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            new WorldWarrior().ShowDialog();
        }

        private void bunifuImageButton29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Shadowbird", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new Shadowbird().ShowDialog();
        }

        private void bunifuImageButton30_Click(object sender, EventArgs e)
        {
            new FinesseFinisher().ShowDialog();
        }

        private void bunifuImageButton31_Click(object sender, EventArgs e)
        {
            new PoisedPlaymaker().ShowDialog();
        }

        private void bunifuImageButton32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Clash", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            new Clash().ShowDialog();
        }

        private void bunifuImageButton33_Click(object sender, EventArgs e)
        {
            new BriteBomber().ShowDialog();
        }

        private void bunifuImageButton34_Click(object sender, EventArgs e)
        {
            new BunnyBrawler().ShowDialog();
        }

        private void bunifuImageButton35_Click(object sender, EventArgs e)
        {
            new EliteAgent().ShowDialog();
        }

        private void bunifuImageButton36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Scarlet Commander", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new Manic().ShowDialog();
        }

        private void bunifuImageButton37_Click(object sender, EventArgs e)
        {
            new DarkVoyager().ShowDialog();
        }

        private void bunifuImageButton38_Click(object sender, EventArgs e)
        {
            new TriceraOps().ShowDialog();
        }

        private void bunifuImageButton39_Click(object sender, EventArgs e)
        {
            new MogulMasterUSA().ShowDialog();
        }

        private void bunifuImageButton40_Click(object sender, EventArgs e)
        {
            new Crusher().ShowDialog();
        }

        private void bunifuImageButton41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Domino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new Domino().ShowDialog();
        }

        private void bunifuImageButton42_Click(object sender, EventArgs e)
        {
            new MogulMasterCAN().ShowDialog();
        }

        private void bunifuImageButton43_Click(object sender, EventArgs e)
        {
            new MogulMasterGBR().ShowDialog();
        }

        private void bunifuImageButton44_Click(object sender, EventArgs e)
        {
            new MogulMasterFRA().ShowDialog();
        }

        private void bunifuImageButton45_Click(object sender, EventArgs e)
        {
            new MogulMasterGER().ShowDialog();
        }

        private void bunifuImageButton46_Click(object sender, EventArgs e)
        {
            new MogulMasterCHN().ShowDialog();
        }

        private void bunifuImageButton47_Click(object sender, EventArgs e)
        {
            new MogulMasterKOR().ShowDialog();
        }

        private void bunifuImageButton48_Click(object sender, EventArgs e)
        {
            new MogulMaster().ShowDialog();
        }

        private void bunifuImageButton49_Click(object sender, EventArgs e)
        {
            new Drake().ShowDialog();
        }

        private void bunifuImageButton50_Click(object sender, EventArgs e)
        {
            new GalaxyOption().ShowDialog();
        }

        private void bunifuImageButton51_Click(object sender, EventArgs e)
        {
            new RenegadeRaiderMat().ShowDialog();
        }

        private void bunifuImageButton52_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Whiteout().ShowDialog();
        }

        private void bunifuImageButton53_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Kyra().ShowDialog();
        }

        private void bunifuImageButton54_Click(object sender, EventArgs e)
        {
            new RenegadeRaiderCMat().ShowDialog();
        }

        private void bunifuImageButton55_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin appears as Skull Trooper (Inverted) in lobby, but Skull Trooper (Purple) in game.", "Skull Trooper (Purple)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new SkullTrooper().ShowDialog();
        }

        private void bunifuImageButton56_Click(object sender, EventArgs e)
        {
            new Havoc().ShowDialog();
        }

        private void bunifuImageButton57_Click(object sender, EventArgs e)
        {
            new Velocity().ShowDialog();
        }

        private void bunifuImageButton58_Click(object sender, EventArgs e)
        {
            new Fate().ShowDialog();
        }

        private void bunifuImageButton59_Click(object sender, EventArgs e)
        {
            new Plague().ShowDialog();
        }

        private void bunifuImageButton60_Click(object sender, EventArgs e)
        {
            new BrilliantStriker().ShowDialog();
        }

        private void bunifuImageButton61_Click(object sender, EventArgs e)
        {
            new Maven().ShowDialog();
        }

        private void bunifuImageButton62_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Tropical Punch Zoey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new TropicalPunchZoey().ShowDialog();
        }

        private void bunifuImageButton64_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new GingerGunner().ShowDialog();
        }

        private void bunifuImageButton63_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new BeachBomber().ShowDialog();
        }

        private void bunifuImageButton65_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new ChaosAgent().ShowDialog();
        }

        private void bunifuImageButton67_Click(object sender, EventArgs e)
        {
            new AstroJack().ShowDialog();
        }

        private void bunifuImageButton66_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Dynamo().ShowDialog();
        }

        private void bunifuImageButton68_Click(object sender, EventArgs e)
        {
            new CloakedShadow().ShowDialog();
        }

        private void bunifuImageButton69_Click(object sender, EventArgs e)
        {
            new Breakpoint().ShowDialog();
        }

        private void bunifuImageButton70_Click(object sender, EventArgs e)
        {
            new PsychoBandit().ShowDialog();
        }

        private void bunifuImageButton71_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This skin does not have a head!", "Siren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            new Siren().ShowDialog();
        }

        private void bunifuImageButton72_Click(object sender, EventArgs e)
        {
            new NogOps().ShowDialog();
        }

        private void bunifuImageButton73_Click(object sender, EventArgs e)
        {
            new ReconSpecialist().ShowDialog();
        }
    }
}
