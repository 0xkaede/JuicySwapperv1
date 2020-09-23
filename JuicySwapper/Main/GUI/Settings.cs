using JuicySwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectPakPathButton_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                Title = "Choose Pak File Directory",
                IsFolderPicker = true,
                InitialDirectory = "C:\\"
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists($"{dialog.FileName}\\pakchunk10-WindowsClient.pak"))
                {
                    pakPathTextbox.Text = dialog.FileName;
                    Properties.Settings.Default.pakPath = pakPathTextbox.Text;
                    Properties.Settings.Default.Save();
                    pakPathTextbox.Text = Properties.Settings.Default.pakPath;
                }
                else
                {
                    MessageBox.Show("Please select the correct directory!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pakPathTextbox.Text = Properties.Settings.Default.pakPath;
        }

        private void resetConfigButton_Click(object sender, EventArgs e)
        {
            new ResetConfirm().ShowDialog();
        }

        private void convertedItemsButton_Click(object sender, EventArgs e)
        {
            int num = 0;
            string text = "";
            //
            //Skins enabled
            //
            if (Settings.Default.ReconSpecialistEnabled == true)
            {
                num++;
                text += "Recon Specialist," + " ";
            }
            if (Settings.Default.PsychoBanditEnabled == true)
            {
                num++;
                text += "Psycho Bandit," + " ";
            }
            if (Settings.Default.NogOpsEnabled == true)
            {
                num++;
                text += "Nog Ops," + " ";
            }
            if (Settings.Default.SirenEnabled == true)
            {
                num++;
                text += "Siren," + " ";
            }
            if (Settings.Default.CloakedShadowEnabled == true)
            {
                num++;
                text += "Cloaked Shadow," + " ";
            }
            if (Settings.Default.AerialEnabled == true)
            {
                num++;
                text += "Aerial Assault Trooper," + " ";
            }
            if (Settings.Default.AutumnQueenEnabled == true)
            {
                num++;
                text += "Autumn Queen," + " ";
            }
            if (Settings.Default.BirdieEnabled == true)
            {
                num++;
                text += "Birdie," + " ";
            }
            if (Settings.Default.BKEnabled == true)
            {
                num++;
                text += "Black Knight," + " ";
            }
            if (Settings.Default.BoltEnabled == true)
            {
                num++;
                text += "Bolt," + " ";
            }
            if (Settings.Default.BracerEnabled == true)
            {
                num++;
                text += "Bracer," + " ";
            }
            if (Settings.Default.BriteBomberEnabled == true)
            {
                num++;
                text += "Brite Bomber," + " ";
            }
            if (Settings.Default.BunnyBrawlerEnabled == true)
            {
                num++;
                text += "Bunny Brawler," + " ";
            }
            if (Settings.Default.ClashEnabled == true)
            {
                num++;
                text += "Clash," + " ";
            }
            if (Settings.Default.CrusherEnabled == true)
            {
                num++;
                text += "Crusher," + " ";
            }
            if (Settings.Default.DarkVoyagerEnabled == true)
            {
                num++;
                text += "Dark Voyager," + " ";
            }
            if (Settings.Default.DominoEnabled == true)
            {
                num++;
                text += "Domino," + " ";
            }
            if (Settings.Default.DoublecrossEnabled == true)
            {
                num++;
                text += "Doublecross," + " ";
            }
            if (Settings.Default.EliteAgentEnabled == true)
            {
                num++;
                text += "Elite Agent (No Helmet)," + " ";
            }
            if (Settings.Default.FinesseEnabled == true)
            {
                num++;
                text += "Finesse Finisher," + " ";
            }
            if (Settings.Default.GhoulOGEnabled == true)
            {
                num++;
                text += "Ghoul Trooper (OG) with Nitelite," + " ";
            }
            if (Settings.Default.GlowEnabled == true)
            {
                num++;
                text += "Glow," + " ";
            }
            if (Settings.Default.HeidiEnabled == true)
            {
                num++;
                text += "Heidi," + " ";
            }
            if (Settings.Default.HushEnabled == true)
            {
                num++;
                text += "Hush," + " ";
            }
            if (Settings.Default.IkonikEnabled == true)
            {
                num++;
                text += "Ikonik," + " ";
            }
            if (Settings.Default.InfernoEnabled == true)
            {
                num++;
                text += "Inferno," + " ";
            }
            if (Settings.Default.ManicEnabled == true)
            {
                num++;
                text += "Manic," + " ";
            }
            if (Settings.Default.MezmerEnabled == true)
            {
                num++;
                text += "Mezmer," + " ";
            }
            if (Settings.Default.MogulEnabled == true)
            {
                num++;
                text += "Mogul Master," + " ";
            }
            if (Settings.Default.MogulCANEnabled == true)
            {
                num++;
                text += "Mogul Master (CAN)," + " ";
            }
            if (Settings.Default.MogulCHNEnabled == true)
            {
                num++;
                text += "Mogul Master (CHN)," + " ";
            }
            if (Settings.Default.MogulFRAEnabled == true)
            {
                num++;
                text += "Mogul Master (FRA)," + " ";
            }
            if (Settings.Default.MogulFRAEnabled == true)
            {
                num++;
                text += "Mogul Master (FRA)," + " ";
            }
            if (Settings.Default.MogulGBREnabled == true)
            {
                num++;
                text += "Mogul Master (GBR)," + " ";
            }
            if (Settings.Default.MogulGEREnabled == true)
            {
                num++;
                text += "Mogul Master (GER)," + " ";
            }
            if (Settings.Default.MogulKOREnabled == true)
            {
                num++;
                text += "Mogul Master (KOR)," + " ";
            }
            if (Settings.Default.PoisedEnabled == true)
            {
                num++;
                text += "Poised Playmaker," + " ";
            }
            if (Settings.Default.PunchyEnabled == true)
            {
                num++;
                text += "Moxie," + " ";
            }
            if (Settings.Default.RedNosedEnabled == true)
            {
                num++;
                text += "Red Nosed Raider," + " ";
            }
            if (Settings.Default.RenegadeEnabled == true)
            {
                num++;
                text += "Renegade Raider with Redline," + " ";
            }
            if (Settings.Default.RenegadeCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered) with Redline," + " ";
            }
            if (Settings.Default.RubyEnabled == true)
            {
                num++;
                text += "Ruby," + " ";
            }
            if (Settings.Default.ScarletEnabled == true)
            {
                num++;
                text += "Scarlet Defender," + " ";
            }
            if (Settings.Default.ShadowbirdEnabled == true)
            {
                num++;
                text += "Shadowbird," + " ";
            }
            if (Settings.Default.SkullRangerEnabled == true)
            {
                num++;
                text += "Skull Ranger," + " ";
            }
            if (Settings.Default.SparkleEnabled == true)
            {
                num++;
                text += "Sparkle Specialist," + " ";
            }
            if (Settings.Default.SparkplugEnabled == true)
            {
                num++;
                text += "Sparkplug," + " ";
            }
            if (Settings.Default.StealthReflexEnabled == true)
            {
                num++;
                text += "Stealth Reflex," + " ";
            }
            if (Settings.Default.TriceraOpsEnabled == true)
            {
                num++;
                text += "Tricera Ops," + " ";
            }
            if (Settings.Default.WonderEnabled == true)
            {
                num++;
                text += "Wonder," + " ";
            }
            if (Settings.Default.WorldWarriorEnabled == true)
            {
                num++;
                text += "World Warrior," + " ";
            }
            if (Settings.Default.ZadieEnabled == true)
            {
                num++;
                text += "Zadie," + " ";
            }
            if (Settings.Default.DrakeEnabled == true)
            {
                num++;
                text += "Drake," + " ";
            }
            if (Settings.Default.GalaxyEnabled == true)
            {
                num++;
                text += "Galaxy with Nitelite," + " ";
            }
            if (Settings.Default.ScarletCommanderEnabled == true)
            {
                num++;
                text += "Scarlet Commander," + " ";
            }
            if (Settings.Default.DreamGalaxyEnabled == true)
            {
                num++;
                text += "Galaxy with Dream," + " ";
            }
            if (Settings.Default.WhiteoutEnabled == true)
            {
                num++;
                text += "Whiteout," + " ";
            }
            if (Settings.Default.KyraEnabled == true)
            {
                num++;
                text += "Kyra," + " ";
            }
            if (Settings.Default.RenegadeRaiderEnabled == true)
            {
                num++;
                text += "Renegade Raider with Blaze," + " ";
            }
            if (Settings.Default.RenegadeRaiderCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered) with Blaze," + " ";
            }
            if (Settings.Default.HavocEnabled == true)
            {
                num++;
                text += "Havoc," + " ";
            }
            if (Settings.Default.VelocityEnabled == true)
            {
                num++;
                text += "Velocity," + " ";
            }
            if (Settings.Default.SkullTrooperEnabled == true)
            {
                num++;
                text += "Skull Trooper (Purple) with Lt. Evergreen," + " ";
            }
            if (Settings.Default.FateEnabled == true)
            {
                num++;
                text += "Fate," + " ";
            }
            if (Settings.Default.PlagueEnabled == true)
            {
                num++;
                text += "Plague," + " ";
            }
            if (Settings.Default.BrilliantStrikerEnabled == true)
            {
                num++;
                text += "Brilliant Striker," + " ";
            }
            if (Settings.Default.MavenEnabled == true)
            {
                num++;
                text += "Maven," + " ";
            }
            if (Settings.Default.TropicalZoeyEnabled == true)
            {
                num++;
                text += "Tropical Punch Zoey," + " ";
            }
            if (Settings.Default.GingerGunnerEnabled == true)
            {
                num++;
                text += "Ginger Gunner," + " ";
            }
            if (Settings.Default.BeachBomberEnabled == true)
            {
                num++;
                text += "Beach Bomber," + " ";
            }
            if (Settings.Default.ChaosAgentEnabled == true)
            {
                num++;
                text += "Chaos Agent," + " ";
            }
            if (Settings.Default.AstroJackEnabled == true)
            {
                num++;
                text += "Astro Jack," + " ";
            }
            if (Settings.Default.DynamoEnabled == true)
            {
                num++;
                text += "Dynamo," + " ";
            }
            //
            //Backblings converted
            //
            if (Properties.Settings.Default.LoveWingsEnabled == true)
            {
                num++;
                text += "Love Wings," + " ";
            }
            if (Properties.Settings.Default.BlackShieldEnabled == true)
            {
                num++;
                text += "Black Shield," + " ";
            }
            if (Properties.Settings.Default.IllusionRuneEnabled == true)
            {
                num++;
                text += "Illusion Rune," + " ";
            }
            if (Properties.Settings.Default.FlameSigilEnabled == true)
            {
                num++;
                text += "Flame Sigil," + " ";
            }
            if (Properties.Settings.Default.GalacticDiscEnabled == true)
            {
                num++;
                text += "Galactic Disc," + " ";
            }
            if (Properties.Settings.Default.FallenWingsEnabled == true)
            {
                num++;
                text += "Fallen Wings," + " ";
            }
            if (Properties.Settings.Default.DiscoBallEnabled == true)
            {
                num++;
                text += "Disco Ball," + " ";
            }
            if (Properties.Settings.Default.GalaxyWingsEnabled == true)
            {
                num++;
                text += "Galaxy Wings," + " ";
            }
            if (Properties.Settings.Default.FireVortexEnabled == true)
            {
                num++;
                text += "Fire Vortex," + " ";
            }
            if (Properties.Settings.Default.GhostPortalEnabled == true)
            {
                num++;
                text += "Ghost Portal," + " ";
            }
            if (Properties.Settings.Default.GlimmeringCloakEnabled == true)
            {
                num++;
                text += "Glimmering Cloak," + " ";
            }
            if (Properties.Settings.Default.InsigniaEnabled == true)
            {
                num++;
                text += "Insignia," + " ";
            }
            if (Properties.Settings.Default.RainbowCloverEnabled == true)
            {
                num++;
                text += "Rainbow Clover," + " ";
            }
            if (Properties.Settings.Default.BackupPlanEnabled == true)
            {
                num++;
                text += "Backup Plan," + " ";
            }
            if (Properties.Settings.Default.AutumnsMantleEnabled == true)
            {
                num++;
                text += "Autumn's Mantle," + " ";
            }
            if (Properties.Settings.Default.BattleShroudEnabled == true)
            {
                num++;
                text += "Battle Shroud," + " ";
            }
            if (Properties.Settings.Default.CovenCapeEnabled == true)
            {
                num++;
                text += "Coven Cape," + " ";
            }
            if (Properties.Settings.Default.CrestedCapeEnabled == true)
            {
                num++;
                text += "Crested Cape," + " ";
            }
            if (Properties.Settings.Default.CuddleBowEnabled == true)
            {
                num++;
                text += "Cuddle Bow," + " ";
            }
            if (Properties.Settings.Default.DismalEnabled == true)
            {
                num++;
                text += "Dismal," + " ";
            }
            if (Properties.Settings.Default.EnduringCapeEnabled == true)
            {
                num++;
                text += "Enduring Cape," + " ";
            }
            if (Properties.Settings.Default.RoyaleShieldEnabled == true)
            {
                num++;
                text += "Royale Shield," + " ";
            }
            if (Properties.Settings.Default.ScalyEnabled == true)
            {
                num++;
                text += "Scaly," + " ";
            }
            if (Properties.Settings.Default.SixStringEnabled == true)
            {
                num++;
                text += "Six String," + " ";
            }
            if (Properties.Settings.Default.SpectralSpineEnabled == true)
            {
                num++;
                text += "Spectral Spine," + " ";
            }
            if (Properties.Settings.Default.StitchesEnabled == true)
            {
                num++;
                text += "Stitches," + " ";
            }
            if (Properties.Settings.Default.VenturionCapeEnabled == true)
            {
                num++;
                text += "Venturion Cape," + " ";
            }
            if (Properties.Settings.Default.WolfpackEnabled == true)
            {
                num++;
                text += "Wolfpack," + " ";
            }
            //
            //Pickaxes converted
            //
            if (Settings.Default.ACDCEnabled == true)
            {
                num++;
                text += "AC/DC," + " ";
            }
            if (Settings.Default.RaidersRevengeEnabled == true)
            {
                num++;
                text += "Raider's Revenge," + " ";
            }
            if (Settings.Default.MerryMintEnabled == true)
            {
                num++;
                text += "Merry Mint Axe," + " ";
            }
            if (Settings.Default.DualRaidersEnabled == true)
            {
                num++;
                text += "Dual Raider's Revenge," + " ";
            }
            if (Settings.Default.StarWandEnabled == true)
            {
                num++;
                text += "Star Wand," + " ";
            }
            if (Settings.Default.ReaperEnabled == true)
            {
                num++;
                text += "Reaper," + " ";
            }
            if (Settings.Default.PartyAnimalEnabled == true)
            {
                num++;
                text += "Party Animal," + " ";
            }
            if (Settings.Default.StellarAxeEnabled == true)
            {
                num++;
                text += "Stellar Axe," + " ";
            }
            if (Settings.Default.OGDefaultEnabled == true)
            {
                num++;
                text += "Default Pickaxe," + " ";
            }
            if (Settings.Default.CandyAxeEnabled == true)
            {
                num++;
                text += "Candy Axe," + " ";
            }
            if (Settings.Default.StuddedAxeEnabled == true)
            {
                num++;
                text += "Studded Axe," + " ";
            }
            if (Settings.Default.PinkFlamingoEnabled == true)
            {
                num++;
                text += "Pink Flamingo," + " ";
            }
            if (Settings.Default.CrowbarEnabled == true)
            {
                num++;
                text += "Crowbar," + " ";
            }
            if (Settings.Default.HarleyHitterEnabled == true)
            {
                num++;
                text += "Harley Hitter," + " ";
            }
            if (Settings.Default.SpikyEnabled == true)
            {
                num++;
                text += "Spiky," + " ";
            }
            if (Settings.Default.WidowsBiteEnabled == true)
            {
                num++;
                text += "Widow's Bite," + " ";
            }
            if (Settings.Default.DriverEnabled == true)
            {
                num++;
                text += "Driver," + " ";
            }
            if (Settings.Default.AxeOfChampionsEnabled == true)
            {
                num++;
                text += "Axe Of Champions," + " ";
            }
            if (Settings.Default.VisionEnabled == true)
            {
                num++;
                text += "Vision," + " ";
            }
            if (Settings.Default.BootstrapsEnabled == true)
            {
                num++;
                text += "Bootstraps," + " ";
            }
            if (Settings.Default.TrustyNo2Enabled == true)
            {
                num++;
                text += "Trusty  No. 2," + " ";
            }
            if (Settings.Default.IceBreakerEnabled == true)
            {
                num++;
                text += "Ice Breaker," + " ";
            }
            //
            //Emotes converted
            //
            if (Settings.Default.TakeTheLEnabled == true)
            {
                num++;
                text += "Take The L," + " ";
            }
            if (Settings.Default.SlickEnabled == true)
            {
                num++;
                text += "Slick," + " ";
            }
            if (Settings.Default.ScenarioEnabled == true)
            {
                num++;
                text += "Scenario," + " ";
            }
            if (Settings.Default.PonyUpEnabled == true)
            {
                num++;
                text += "Pony Up," + " ";
            }
            if (Settings.Default.PokiEnabled == true)
            {
                num++;
                text += "Poki," + " ";
            }
            if (Settings.Default.NeverGonnaEnabled == true)
            {
                num++;
                text += "Never Gonna," + " ";
            }
            if (Settings.Default.LazerBlastEnabled == true)
            {
                num++;
                text += "Lazer Blast," + " ";
            }
            if (Settings.Default.LlamacadabraEnabled == true)
            {
                num++;
                text += "Llamacadabra," + " ";
            }
            if (Settings.Default.InfectiousEnabled == true)
            {
                num++;
                text += "Infectious," + " ";
            }
            if (Settings.Default.GlowsticksEnabled == true)
            {
                num++;
                text += "Glowsticks," + " ";
            }
            if (Settings.Default.LevitateEnabled == true)
            {
                num++;
                text += "Levitate," + " ";
            }
            if (Settings.Default.FlossEnabled == true)
            {
                num++;
                text += "Floss," + " ";
            }
            if (Settings.Default.FlapperEnabled == true)
            {
                num++;
                text += "Flapper," + " ";
            }
            if (Settings.Default.DaydreamEnabled == true)
            {
                num++;
                text += "Daydream," + " ";
            }
            if (Settings.Default.TheWormEnabled == true)
            {
                num++;
                text += "The Worm," + " ";
            }
            if (Settings.Default.ToosieSlideEnabled == true)
            {
                num++;
                text += "Toosie Slide," + " ";
            }
            if (Settings.Default.FishinEnabled == true)
            {
                num++;
                text += "Fishin'," + " ";
            }
            if (Settings.Default.SmoothMovesEnabled == true)
            {
                num++;
                text += "Smooth Moves," + " ";
            }
            if (Settings.Default.FreestylinEnabled == true)
            {
                num++;
                text += "Freestylin'," + " ";
            }
            if (Settings.Default.CheerUpEnabled == true)
            {
                num++;
                text += "Cheer Up," + " ";
            }
            if (Settings.Default.FreshEnabled == true)
            {
                num++;
                text += "Fresh," + " ";
            }
            if (Settings.Default.OrangeJusticeEnabled == true)
            {
                num++;
                text += "Orange Justice," + " ";
            }
            if (Settings.Default.PopLockEnabled == true)
            {
                num++;
                text += "Pop Lock," + " ";
            }
            if (Settings.Default.TheRenegadeEnabled == true)
            {
                num++;
                text += "The Renegade (Emote)," + " ";
            }
            if (Settings.Default.BhangraBoogieEnabled == true)
            {
                num++;
                text += "Bhangra Boogie," + " ";
            }
            if (Settings.Default.outwestEnabled == true)
            {
                num++;
                text += "Out West," + " ";
            }
            if (Settings.Default.BuckleUpEnabled == true)
            {
                num++;
                text += "Buckle Up," + " ";
            }
            if (Settings.Default.ButterflyKnifeEnabled == true)
            {
                num++;
                text += "Butterfly Knife," + " ";
            }
            //
            //Miscs converted
            //
            if (Settings.Default.JuicyEAC1Enabled == true)
            {
                num++;
                text += "Juicy Swapper EAC Splash Screen (1)," + " ";
            }
            if (Settings.Default.JuicyEAC2Enabled == true)
            {
                num++;
                text += "Juicy Swapper EAC Splash Screen (2)," + " ";
            }
            if (Settings.Default.ScenarioMusicEnabled == true)
            {
                num++;
                text += "Scenario Music," + " ";
            }
            if (Settings.Default.ToosieMusicEnabled == true)
            {
                num++;
                text += "Toosie Music," + " ";
            }
            if (Settings.Default.SuperOGEnabled == true)
            {
                num++;
                text += "Super OG Music," + " ";
            }
            //
            if (num == 0)
            {
                MessageBox.Show(this, "You currently have no items converted!", "Converted Items List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (num == 1)
            {
                MessageBox.Show(this, "You currently have 1 item converted: " + text.Remove(text.Length - 2) + ".", "Converted Items List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (num > 1)
            {
                MessageBox.Show(this, "You currently have " + num.ToString() + " items converted: " + text.Remove(text.Length - 2) + ".", "Converted Items List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateCheckButton_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Proxy = null;
                    string text = webClient.DownloadString("https://juicyswapper.xyz/api/version").ToString();
                    if (text != Application.ProductVersion)
                    {
                        MessageBox.Show("You are using an outdated version of Juicy Swapper! " + ("The most recent version of Juicy Swapper is v" + text) + " and you are currently using v" + Application.ProductVersion + ". Please close the swapper and launch 'Juicy Updater.exe'");
                    }
                    else
                    {
                        MessageBox.Show("You are up to date, and you are currently using v" + Application.ProductVersion + ".");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: SERVER_ERROR");
                }
            }
        }

        private void advancedButton_Click(object sender, EventArgs e)
        {
            new AdvancedSettings().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MediaPlayerMenu().Show();
        }
    }
}
