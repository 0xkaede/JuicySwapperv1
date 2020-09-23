using JuicyIDSwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicyIDSwapper.Main.GUI
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
                    MessageBox.Show("Please select the correct directory!", "Juicy ID Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (Settings.Default.RenegadeRaiderEnabled == true)
            {
                num++;
                text += "Renegade Raider," + " ";
            }
            if (Settings.Default.BlackKnightEnabled == true)
            {
                num++;
                text += "Black Knight," + " ";
            }
            if (Settings.Default.AerialAssaultTrooperEnabled == true)
            {
                num++;
                text += "Aerial Assault Trooper," + " ";
            }
            if (Settings.Default.GhoulTrooperEnabled == true)
            {
                num++;
                text += "Ghoul Trooper," + " ";
            }
            if (Settings.Default.SkullTrooperEnabled == true)
            {
                num++;
                text += "Skull Trooper," + " ";
            }
            if (Settings.Default.HonorGuardEnabled == true)
            {
                num++;
                text += "Honor Guard," + " ";
            }
            if (Settings.Default.IkonikEnabled == true)
            {
                num++;
                text += "Ikonik," + " ";
            }
            if (Settings.Default.GalaxyEnabled == true)
            {
                num++;
                text += "Galaxy," + " ";
            }
            if (Settings.Default.GlowEnabled == true)
            {
                num++;
                text += "Glow," + " ";
            }
            if (Settings.Default.ShadowArchetypeEnabled == true)
            {
                num++;
                text += "Shadow Archetype," + " ";
            }
            if (Settings.Default.DarkVertexEnabled == true)
            {
                num++;
                text += "Dark Vertex," + " ";
            }
            if (Settings.Default.WonderEnabled == true)
            {
                num++;
                text += "Wonder," + " ";
            }
            if (Settings.Default.StealthReflexEnabled == true)
            {
                num++;
                text += "Stealth Reflex," + " ";
            }
            if (Settings.Default.NiteGunnerEnabled == true)
            {
                num++;
                text += "Nite Gunner," + " ";
            }
            //
            //Backblings converted
            //
            if (Settings.Default.BackupPlanEnabled == true)
            {
                num++;
                text += "Backup Plan," + " ";
            }
            if (Settings.Default.BlackShieldEnabled == true)
            {
                num++;
                text += "Black Shield," + " ";
            }
            if (Settings.Default.GhostPortalEnabled == true)
            {
                num++;
                text += "Ghost Portal," + " ";
            }
            if (Settings.Default.GalacticDiscEnabled == true)
            {
                num++;
                text += "Galactic Disc," + " ";
            }
            if (Settings.Default.DarkDeflectorEnabled == true)
            {
                num++;
                text += "Dark Deflector," + " ";
            }
            if (Settings.Default.RoyaleShieldEnabled == true)
            {
                num++;
                text += "Royale Shield," + " ";
            }
            if (Settings.Default.RogueSpiderShieldEnabled == true)
            {
                num++;
                text += "Rogue Spider Shield," + " ";
            }
            //
            //Emotes converted
            //
            if (Settings.Default.FlossEnabled == true)
            {
                num++;
                text += "Floss," + " ";
            }
            if (Settings.Default.ScenarioEnabled == true)
            {
                num++;
                text += "Scenario," + " ";
            }
            if (Settings.Default.TheWormEnabled == true)
            {
                num++;
                text += "The Worm," + " ";
            }
            if (Settings.Default.TheRenegadeEnabled == true)
            {
                num++;
                text += "The Renegade," + " ";
            }
            if (Settings.Default.BhangraBoogieEnabled == true)
            {
                num++;
                text += "Bhangra Boogie," + " ";
            }
            if (Settings.Default.PonyUpEnabled == true)
            {
                num++;
                text += "Pony Up," + " ";
            }
            if (Settings.Default.LevitateEnabled == true)
            {
                num++;
                text += "Levitate," + " ";
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
                    string text = webClient.DownloadString("https://juicyswapper.xyz/api/id/version").ToString();
                    if (text != Application.ProductVersion)
                    {
                        MessageBox.Show("You are using an outdated version of Juicy ID Swapper! " + ("The most recent version of Juicy Swapper is v" + text) + " and you are currently using v" + Application.ProductVersion + ". Please close the swapper and launch 'Juicy Updater.exe'");
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
