using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class PinkFlamingo : Form
    {
        public PinkFlamingo()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string PakFolder = Properties.Settings.Default.pakPath;

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath9 = Settings.Default.pakPath + "/pakchunk10_s9-WindowsClient.pak";

            if (!File.Exists(filePath9))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }

            else
            {
                CheckForIllegalCrossThreadCalls = false; int offsetskin1 = Settings.Default.offsetskin1; int offsetpick = Settings.Default.offsetpick; int offsetback = Settings.Default.offsetback; int offsetskin2 = Settings.Default.offsetskin2; int offsetemote = Settings.Default.offsetemote; int offsetlobby = Settings.Default.offsetlobby; int offsetpickmesh = Settings.Default.offsetpickmesh;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PinkFlamingoEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_Balloon/Meshes/SK_Pickaxe_Balloon.SK_Pickaxe_Balloon";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Meshes/SK_PickAxe_Flamingo.SK_PickAxe_Flamingo";
        string Equip = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Ready_Cue.Pickaxe_Balloon_Ready_Cue";
        string Equip1 = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Ready_Cue.Pickaxe_Balloon_Ready_000";
        string Swing = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Swing_Cue.Pickaxe_Balloon_Swing_Cue";
        string Swing1 = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Swing_Cue.Pickaxe_Balloon_Swing_000";
        string Impact = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Impact_Cue.Pickaxe_Balloon_Impact_Cue";
        string Impact1 = "/Game/Athena/Sounds/Weapons/PickAxes/Balloon/Pickaxe_Balloon_Impact_Cue.Pickaxe_Balloon_Impact_000";
        string Swingfx = "/Game/Effects/Fort_Effects/Effects/Melee/P_Melee_Trail_Default.P_Melee_Trail_Default";
        string Swingfx1 = "/Game/Effects/Fort_Effects/Effects/Melee/P_Melee_Trail_Pink.P_Melee_Trail_Pink";
        string Impactfx = "/Game/Weapons/FORT_Melee/Pickaxe_Balloon/FX/P_Pickaxe_Balloon_Impact.P_Pickaxe_Balloon_Impact";
        string Impactfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_Balloon/FX/P_Pickaxe_Balloon_Impact.P_Pickaxe_Balloon_Imp000";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SK-Pickaxe-Balloon-Transparent.T-Icon-Pickaxes-SK-Pickaxe-Balloon-Transparent";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SK-PickAxe-Flamingo.T-Icon-Pickaxes-SK-PickAxe-Flamingo";
        string Rarity = "EFortRarity::Rare";
        string Rarity1 = "EFortRarity::Epic";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int Offset_Skin_Body = Settings.Default.offsetskin1;
            int offsetpick = Settings.Default.offsetpick;
            int offsetback = Settings.Default.offsetback;
            int Offset_Skin_Head = Settings.Default.offsetskin2;
            int offsetemote = Settings.Default.offsetemote;
            int offsetlobby = Settings.Default.offsetlobby;
            int offsetpickmesh = Settings.Default.offsetpickmesh;


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Convert(offsetpick, pickaxepath, Mesh, Mesh1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Mesh added";
                    Settings.Default.PinkFlamingoEnabled = true;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Convert(offsetpick, pickaxepath, Equip, Equip1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound added";

                bool swap3 = Engine.Convert(offsetpick, pickaxepath, Impact, Impact1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Sound added";

                bool swap4 = Engine.Convert(offsetpick, pickaxepath, Swing, Swing1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Sound added";

                long current_offset = Settings.Default.current_offset;
                bool swap5 = Engine.Convert(current_offset, pickaxepath, Swingfx, Swingfx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Trail added";

                bool swap6 = Engine.Convert(offsetpick, pickaxepath, Impactfx, Impactfx1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Effect added";


                bool swap8 = Engine.Convert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Icon added";

                long offset_current = Settings.Default.current_offset;

                bool swap10 = Engine.Convert(offset_current, pickaxepath, Rarity, Rarity1, 0, 0, false, false);
                if (swap10)
                    RichTextBoxInfo.Text += "\n[LOG] Rarity added";

                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Revert(offsetpick, pickaxepath, Mesh, Mesh1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Mesh removed";
                    Settings.Default.PinkFlamingoEnabled = false;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Revert(offsetpick, pickaxepath, Equip, Equip1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound removed";

                bool swap3 = Engine.Revert(offsetpick, pickaxepath, Swing, Swing1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Sound removed";

                bool swap4 = Engine.Revert(offsetpick, pickaxepath, Impact, Impact1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Sound removed";

                long current_offset = Settings.Default.current_offset;
                bool swap5 = Engine.Revert(current_offset, pickaxepath, Swingfx, Swingfx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Trail removed";

                bool swap6 = Engine.Revert(offsetpick, pickaxepath, Impactfx, Impactfx1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Effect removed";


                bool swap8 = Engine.Revert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Icon removed";

                long offset_current = Settings.Default.current_offset;

                bool swap10 = Engine.Revert(offset_current, pickaxepath, Rarity, Rarity1, 0, 0, false, false);
                if (swap10)
                    RichTextBoxInfo.Text += "\n[LOG] Rarity removed";

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
