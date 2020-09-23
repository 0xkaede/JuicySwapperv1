using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class AxeOfChampions : Form
    {
        public AxeOfChampions()
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
            if (Properties.Settings.Default.AxeOfChampionsEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_Cat_Burglar_Male/Meshes/Cat_Burglar_Male_Axe.Cat_Burglar_Male_Axe";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Pickaxe_FNCS/Meshes/SK_Pickaxe_FNCS.SK_Pickaxe_FNCS";
        string Equip = "/Game/Athena/Sounds/Weapons/PickAxes/CatBurglarMale/PickAxe_CatBurglar_Ready_Athena_Cue.PickAxe_CatBurglar_Ready_Athena_Cue";
        string Equip1 = "/Game/Athena/Sounds/Weapons/PickAxes/FNCS/PickaxeReady_FNCS.PickaxeReady_FNCS";
        string Swing = "/Game/Athena/Sounds/Weapons/PickAxes/CatBurglarMale/PickAxe_CatBurglar_Swing_Athena_Cue.PickAxe_CatBurglar_Swing_Athena_Cue";
        string Swing1 = "/Game/Athena/Sounds/Weapons/PickAxes/FNCS/PickaxeSwing_FNCS.PickaxeSwing_FNCS";
        string Impact = "/Game/Athena/Sounds/Weapons/PickAxes/CatBurglarMale/PickAxe_CatBurglar_Impact_Player_Athena_Cue.PickAxe_CatBurglar_Impact_Player_Athena_Cue";
        string Impact1 = "/Game/Athena/Sounds/Weapons/PickAxes/FNCS/PickaxeImpactEnemy_FNCS.PickaxeImpactEnemy_FNCS";
        string Trail = "/Game/Weapons/FORT_Melee/Pickaxe_Cat_Burglar_Male/FX/P_Melee_Trail_CatBurglar_Skeleton.P_Melee_Trail_CatBurglar_Skeleton";
        string Trail1 = "/Game/Effects/Fort_Effects/Effects/Melee/P_Melee_Trail_Default.P_Melee_Trail_Default";
        string Idlefx = "/Game/Weapons/FORT_Melee/Pickaxe_Cat_Burglar_Male/FX/P_CatBurglar_Pickaxe_Idle.P_CatBurglar_Pickaxe_Idle";
        string Idlefx1 = "/Game/Weapons/FORT_Melee/Pickaxe_Cat_Burglar_Male/FX/P_FNCS_Pickaxe_Idle.P_FNCS_Pickaxe_Idle";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-CatBurglarMPickaxe.T-Icon-Pickaxes-CatBurglarMPickaxe";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-FNCSPickaxe.T-Icon-Pickaxes-FNCSPickaxe";
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
                    Settings.Default.AxeOfChampionsEnabled = true;
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

                bool swap5 = Engine.Convert(offsetpick, pickaxepath, Idlefx, Idlefx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Idle Effect added";

                long current_offset = Settings.Default.current_offset;
                bool swap6 = Engine.Convert(current_offset, pickaxepath, Trail, Trail1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Trail Effect added";

                bool swap7 = Engine.Convert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Icon added";

                long offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Convert(offset_current, pickaxepath, Rarity, Rarity1, 0, 0, false, false);
                if (swap8)
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
                    Settings.Default.AxeOfChampionsEnabled = false;
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

                bool swap5 = Engine.Revert(offsetpick, pickaxepath, Idlefx, Idlefx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Idle Effect removed";

                long current_offset = Settings.Default.current_offset;
                bool swap6 = Engine.Revert(current_offset, pickaxepath, Trail, Trail1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Trail Effect removed";

                bool swap7 = Engine.Revert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Icon removed";

                long offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Revert(offset_current, pickaxepath, Rarity, Rarity1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Rarity removed";

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
