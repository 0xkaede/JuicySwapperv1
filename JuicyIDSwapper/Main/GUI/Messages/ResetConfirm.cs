using System;
using System.Media;
using System.Windows.Forms;

namespace JuicyIDSwapper.Main.GUI
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
            Properties.Settings.Default.RenegadeRaiderEnabled = false;
            Properties.Settings.Default.BlackKnightEnabled = false;
            Properties.Settings.Default.AerialAssaultTrooperEnabled = false;
            Properties.Settings.Default.GhoulTrooperEnabled = false;
            Properties.Settings.Default.SkullTrooperEnabled = false;
            Properties.Settings.Default.HonorGuardEnabled = false;
            Properties.Settings.Default.IkonikEnabled = false;
            Properties.Settings.Default.GalaxyEnabled = false;
            Properties.Settings.Default.GlowEnabled = false;
            Properties.Settings.Default.ShadowArchetypeEnabled = false;
            Properties.Settings.Default.DarkVertexEnabled = false;
            Properties.Settings.Default.WonderEnabled = false;
            Properties.Settings.Default.StealthReflexEnabled = false;
            Properties.Settings.Default.NiteGunnerEnabled = false;
            //
            //Backblings config
            //
            Properties.Settings.Default.BackupPlanEnabled = false;
            Properties.Settings.Default.BlackShieldEnabled = false;
            Properties.Settings.Default.GhostPortalEnabled = false;
            Properties.Settings.Default.GalacticDiscEnabled = false;
            Properties.Settings.Default.DarkDeflectorEnabled = false;
            Properties.Settings.Default.RoyaleShieldEnabled = false;
            Properties.Settings.Default.RogueSpiderShieldEnabled = false;
            //
            //Emotes config
            //
            Properties.Settings.Default.FlossEnabled = false;
            Properties.Settings.Default.ScenarioEnabled = false;
            Properties.Settings.Default.TheWormEnabled = false;
            Properties.Settings.Default.TheRenegadeEnabled = false;
            Properties.Settings.Default.BhangraBoogieEnabled = false;
            Properties.Settings.Default.PonyUpEnabled = false;
            Properties.Settings.Default.LevitateEnabled = false;
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
