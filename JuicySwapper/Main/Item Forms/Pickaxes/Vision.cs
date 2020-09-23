using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class Vision : Form
    {
        public Vision()
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
            if (Properties.Settings.Default.VisionEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }




        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_Flintlock_RedKnight/Meshes/SK_Pickaxe_Flintlock_RedKnight.SK_Pickaxe_Flintlock_RedKnight";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Pickaxe_StreetGoth/Meshes/Street_Goth_Pickaxe.Street_Goth_Pickaxe";
        string Mat = "/Game/Weapons/FORT_Melee/Pickaxe_Flintlock_RedKnight_Winter/Materials/MI_Pickaxe_Flintlock_RedKnight_Winter.MI_Pickaxe_Flintlock_RedKnight_Winter";
        string Mat1 = "/Game/Weapons/FORT_Melee/Pickaxe_Flintlock_RedKnight_Winter/Materials/MI_Pickaxe_Flintlock_RedKnight_Winter.MI_Pickaxe_Flintlock_RedKnight_Wi0000";
        string Swing = "/Game/Athena/Sounds/Weapons/PickAxes/FlintlockWinter/Pickaxe_WinterFlintlock_Swing.Pickaxe_WinterFlintlock_Swing";
        string Swing1 = "/Game/Athena/Sounds/Weapons/PickAxes/StreetGoth/PA_StreetGoth_Swing_Cue.PA_StreetGoth_Swing_Cue";
        string Equip = "/Game/Athena/Sounds/Weapons/PickAxes/FlintlockWinter/Pickaxe_WinterFlintlock_Ready.Pickaxe_WinterFlintlock_Ready";
        string Equip1 = "/Game/Athena/Sounds/Weapons/PickAxes/StreetGoth/PA_StreetGoth_Ready_Cue.PA_StreetGoth_Ready_Cue";
        string Impact = "/Game/Athena/Sounds/Weapons/PickAxes/FlintlockWinter/Pickaxe_WinterFlintlock_Impact.Pickaxe_WinterFlintlock_Impact";
        string Impact1 = "/Game/Athena/Sounds/Weapons/PickAxes/StreetGoth/PA_StreetGoth_Impact_Cue.PA_StreetGoth_Impact_Cue";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-Pickaxe-ID-143-FlintlockWinter.T-Icon-Pickaxes-Pickaxe-ID-143-FlintlockWinter";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-Pickaxe-ID-140-StreetGoth.T-Icon-Pickaxes-Pickaxe-ID-140-StreetGoth";
        string Series = "FrozenSeries";
        string Series1 = "FrozenSer000";


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
                    Settings.Default.VisionEnabled = true;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Convert(offsetpick, pickaxepath, Equip, Equip1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound added";

                bool swap3 = Engine.Convert(offsetpick, pickaxepath, Swing, Swing1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Sound added";

                bool swap4 = Engine.Convert(offsetpick, pickaxepath, Impact, Impact1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Sound added";

                bool swap5 = Engine.Convert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Icon added";

                bool swap6 = Engine.Convert(offsetpick, pickaxepath, Mat, Mat1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Material added";

                long offset_current = Settings.Default.current_offset;
                bool swap7 = Engine.Convert(offset_current, pickaxepath, Series, Series1, 0, 0, false, false);
                if (swap7)
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
                    Settings.Default.VisionEnabled = false;
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

                bool swap5 = Engine.Revert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Icon removed";

                bool swap6 = Engine.Revert(offsetpick, pickaxepath, Mat, Mat1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Material removed";

                long offset_current = Settings.Default.current_offset;
                bool swap7 = Engine.Revert(offset_current, pickaxepath, Series, Series1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Rarity removed";

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
