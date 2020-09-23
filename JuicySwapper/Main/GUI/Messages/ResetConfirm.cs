using System;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class ResetConfirm : Form
    {
        public ResetConfirm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //
            //Skins config
            //
            Properties.Settings.Default.ReconSpecialistEnabled = false;
            Properties.Settings.Default.BreakpointEnabled = false;
            Properties.Settings.Default.PsychoBanditEnabled = false;
            Properties.Settings.Default.NogOpsEnabled = false;
            Properties.Settings.Default.SirenEnabled = false;
            Properties.Settings.Default.CloakedShadowEnabled = false;
            Properties.Settings.Default.AerialEnabled = false;
            Properties.Settings.Default.AutumnQueenEnabled = false;
            Properties.Settings.Default.BirdieEnabled = false;
            Properties.Settings.Default.BKEnabled = false;
            Properties.Settings.Default.BoltEnabled = false;
            Properties.Settings.Default.BracerEnabled = false;
            Properties.Settings.Default.BriteBomberEnabled = false;
            Properties.Settings.Default.BunnyBrawlerEnabled = false;
            Properties.Settings.Default.ClashEnabled = false;
            Properties.Settings.Default.CrusherEnabled = false;
            Properties.Settings.Default.DarkVoyagerEnabled = false;
            Properties.Settings.Default.DominoEnabled = false;
            Properties.Settings.Default.DoublecrossEnabled = false;
            Properties.Settings.Default.EliteAgentEnabled = false;
            Properties.Settings.Default.FinesseEnabled = false;
            Properties.Settings.Default.GhoulOGEnabled = false;
            Properties.Settings.Default.GlowEnabled = false;
            Properties.Settings.Default.HeidiEnabled = false;
            Properties.Settings.Default.HushEnabled = false;
            Properties.Settings.Default.IkonikEnabled = false;
            Properties.Settings.Default.InfernoEnabled = false;
            Properties.Settings.Default.ManicEnabled = false;
            Properties.Settings.Default.MezmerEnabled = false;
            Properties.Settings.Default.MogulEnabled = false;
            Properties.Settings.Default.MogulCANEnabled = false;
            Properties.Settings.Default.MogulCHNEnabled = false;
            Properties.Settings.Default.MogulFRAEnabled = false;
            Properties.Settings.Default.MogulGBREnabled = false;
            Properties.Settings.Default.MogulGEREnabled = false;
            Properties.Settings.Default.MogulKOREnabled = false;
            Properties.Settings.Default.MogulUSAEnabled = false;
            Properties.Settings.Default.PoisedEnabled = false;
            Properties.Settings.Default.PunchyEnabled = false;
            Properties.Settings.Default.RedNosedEnabled = false;
            Properties.Settings.Default.RenegadeEnabled = false;
            Properties.Settings.Default.RenegadeCEnabled = false;
            Properties.Settings.Default.RubyEnabled = false;
            Properties.Settings.Default.ScarletEnabled = false;
            Properties.Settings.Default.ShadowbirdEnabled = false;
            Properties.Settings.Default.SkullRangerEnabled = false;
            Properties.Settings.Default.SparkleEnabled = false;
            Properties.Settings.Default.SparkplugEnabled = false;
            Properties.Settings.Default.StealthReflexEnabled = false;
            Properties.Settings.Default.TriceraOpsEnabled = false;
            Properties.Settings.Default.WonderEnabled = false;
            Properties.Settings.Default.WorldWarriorEnabled = false;
            Properties.Settings.Default.ZadieEnabled = false;
            Properties.Settings.Default.DrakeEnabled = false;
            Properties.Settings.Default.GalaxyEnabled = false;
            Properties.Settings.Default.ScarletCommanderEnabled = false;
            Properties.Settings.Default.DreamGalaxyEnabled = false;
            Properties.Settings.Default.WhiteoutEnabled = false;
            Properties.Settings.Default.KyraEnabled = false;
            Properties.Settings.Default.RenegadeRaiderEnabled = false;
            Properties.Settings.Default.RenegadeRaiderCEnabled = false;
            Properties.Settings.Default.HavocEnabled = false;
            Properties.Settings.Default.VelocityEnabled = false;
            Properties.Settings.Default.SkullTrooperEnabled = false;
            Properties.Settings.Default.FateEnabled = false;
            Properties.Settings.Default.PlagueEnabled = false;
            Properties.Settings.Default.BrilliantStrikerEnabled = false;
            Properties.Settings.Default.MavenEnabled = false;
            Properties.Settings.Default.TropicalZoeyEnabled = false;
            Properties.Settings.Default.GingerGunnerEnabled = false;
            Properties.Settings.Default.BeachBomberEnabled = false;
            Properties.Settings.Default.ChaosAgentEnabled = false;
            Properties.Settings.Default.AstroJackEnabled = false;
            Properties.Settings.Default.DynamoEnabled = false;
            //
            //Backblings config
            //
            Properties.Settings.Default.LoveWingsEnabled = false;
            Properties.Settings.Default.BlackShieldEnabled = false;
            Properties.Settings.Default.IllusionRuneEnabled = false;
            Properties.Settings.Default.FlameSigilEnabled = false;
            Properties.Settings.Default.GalacticDiscEnabled = false;
            Properties.Settings.Default.FallenWingsEnabled = false;
            Properties.Settings.Default.DiscoBallEnabled = false;
            Properties.Settings.Default.GalaxyWingsEnabled = false;
            Properties.Settings.Default.FireVortexEnabled = false;
            Properties.Settings.Default.GhostPortalEnabled = false;
            Properties.Settings.Default.GlimmeringCloakEnabled = false;
            Properties.Settings.Default.InsigniaEnabled = false;
            Properties.Settings.Default.RainbowCloverEnabled = false;
            Properties.Settings.Default.BackupPlanEnabled = false; 
            Properties.Settings.Default.AutumnsMantleEnabled = false;
            Properties.Settings.Default.BattleShroudEnabled = false;
            Properties.Settings.Default.CovenCapeEnabled = false;
            Properties.Settings.Default.CrestedCapeEnabled = false;
            Properties.Settings.Default.CuddleBowEnabled = false;
            Properties.Settings.Default.DismalEnabled = false;
            Properties.Settings.Default.RoyaleShieldEnabled = false;
            Properties.Settings.Default.ScalyEnabled = false;
            Properties.Settings.Default.SixStringEnabled = false;
            Properties.Settings.Default.SpectralSpineEnabled = false;
            Properties.Settings.Default.StitchesEnabled = false;
            Properties.Settings.Default.VenturionCapeEnabled = false;
            Properties.Settings.Default.WolfpackEnabled = false;
            //
            //Pickaxes config
            //
            Properties.Settings.Default.ACDCEnabled = false;
            Properties.Settings.Default.RaidersRevengeEnabled = false;
            Properties.Settings.Default.MerryMintEnabled = false;
            Properties.Settings.Default.DualRaidersEnabled = false;
            Properties.Settings.Default.StarWandEnabled = false;
            Properties.Settings.Default.ReaperEnabled = false;
            Properties.Settings.Default.PartyAnimalEnabled = false;
            Properties.Settings.Default.OGDefaultEnabled = false;
            Properties.Settings.Default.CandyAxeEnabled = false;
            Properties.Settings.Default.StellarAxeEnabled = false;
            Properties.Settings.Default.StuddedAxeEnabled = false;
            Properties.Settings.Default.PinkFlamingoEnabled = false;
            Properties.Settings.Default.CrowbarEnabled = false;
            Properties.Settings.Default.HarleyHitterEnabled = false;
            Properties.Settings.Default.SpikyEnabled = false;
            Properties.Settings.Default.WidowsBiteEnabled = false;
            Properties.Settings.Default.DriverEnabled = false;
            Properties.Settings.Default.AxeOfChampionsEnabled = false;
            Properties.Settings.Default.VisionEnabled = false;
            Properties.Settings.Default.BootstrapsEnabled = false;
            Properties.Settings.Default.TrustyNo2Enabled = false;
            Properties.Settings.Default.IceBreakerEnabled = false;
            //
            //Emotes config
            //
            Properties.Settings.Default.DaydreamEnabled = false;
            Properties.Settings.Default.FlapperEnabled = false;
            Properties.Settings.Default.FlossEnabled = false;
            Properties.Settings.Default.LevitateEnabled = false;
            Properties.Settings.Default.GlowsticksEnabled = false;
            Properties.Settings.Default.InfectiousEnabled = false;
            Properties.Settings.Default.LlamacadabraEnabled = false;
            Properties.Settings.Default.LazerBlastEnabled = false;
            Properties.Settings.Default.NeverGonnaEnabled = false;
            Properties.Settings.Default.PokiEnabled = false;
            Properties.Settings.Default.PonyUpEnabled = false;
            Properties.Settings.Default.ScenarioEnabled = false;
            Properties.Settings.Default.SlickEnabled = false;
            Properties.Settings.Default.TakeTheLEnabled = false;
            Properties.Settings.Default.TheWormEnabled = false;
            Properties.Settings.Default.ToosieSlideEnabled = false;
            Properties.Settings.Default.FishinEnabled = false;
            Properties.Settings.Default.SmoothMovesEnabled = false;
            Properties.Settings.Default.FreestylinEnabled = false;
            Properties.Settings.Default.CheerUpEnabled = false;
            Properties.Settings.Default.FreshEnabled = false;
            Properties.Settings.Default.OrangeJusticeEnabled = false;
            Properties.Settings.Default.PopLockEnabled = false;
            Properties.Settings.Default.TheRenegadeEnabled = false;
            Properties.Settings.Default.BhangraBoogieEnabled = false;
            Properties.Settings.Default.outwestEnabled = false;
            Properties.Settings.Default.BuckleUpEnabled = false;
            Properties.Settings.Default.ButterflyKnifeEnabled = false;
            //
            //Miscs config
            //
            Properties.Settings.Default.ScenarioMusicEnabled = false;
            Properties.Settings.Default.ToosieMusicEnabled = false;
            Properties.Settings.Default.SuperOGEnabled = false;
            Properties.Settings.Default.JuicyEAC1Enabled = false;
            Properties.Settings.Default.JuicyEAC2Enabled = false;
            //
            Properties.Settings.Default.Save();
            new ResetComplete().ShowDialog();
            Close();
        }

        private void ResetConfirm_Load(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}
