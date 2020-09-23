using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class ACDC : Form
    {
        public ACDC()
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
            if (Properties.Settings.Default.ACDCEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/Meshes/Sweater_Weather_Male_Axe.Sweater_Weather_Male_Axe";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Meshes/SK_Pickaxe_12.SK_Pickaxe_12";
        string Equip = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Ready_Athena_Cue.PickAxe_SweaterWeatherMale_Ready_Athena_Cue";
        string Equip1 = "/Game/Sounds/Fort_Weapons/PickAxe/PickAxe_TeslaCoil_Ready_Cue.PickAxe_TeslaCoil_Ready_Cue";
        string Swing = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Swing_Athena_Cue.PickAxe_SweaterWeatherMale_Swing_Athena_Cue";
        string Swing1 = "/Game/Sounds/Fort_Weapons/PickAxe/PickAxe_TeslaCoil_Swing_Cue.PickAxe_TeslaCoil_Swing_Cue";
        string Impact = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Impact_Player_Athena_Cue.PickAxe_SweaterWeatherMale_Impact_Player_Athena_Cue";
        string Impact1 = "/Game/Sounds/Fort_Impact_Sounds/Demolition/Defaults/Demo_Rock_Impact_MLTI_Cue.Demo_Rock_Impact_MLTI_Cue";
        string Swingfx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeatherMale_Swing.P_Pickaxe_SweaterWeatherMale_Swing";
        string Swingfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_Dragon_Ninja/FX/P_Pickaxe_Dragon_Ninja_Swing.P_Pickaxe_Dragon_Ninja_Swing";
        string Impactfx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeather_Impact.P_Pickaxe_SweaterWeather_Impact";
        string Impactfx1 = "/Game/Weapons/FORT_Generic_Effects/Impacts/Default/P_Impact_Default_Electrical_01.P_Impact_Default_Electrical_01";
        string Idlefx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeatherMale_Idle.P_Pickaxe_SweaterWeatherMale_Idle";
        string Idlefx1 = "/Game/Weapons/FORT_Melee/Effects/Electrical_Pickaxe/P_Electrical_PickAxe_Head_01.P_Electrical_PickAxe_Head_01";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SweaterWeatherPickaxe.T-Icon-Pickaxes-SweaterWeatherPickaxe";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SK-Pickaxe-12.T-Icon-Pickaxes-SK-Pickaxe-12";
        string fx = "FX_Idle_Start";
        string fx1 = "FX_TeslaHead";
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
                    Settings.Default.ACDCEnabled = true;
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

                bool swap5 = Engine.Convert(offsetpick, pickaxepath, Swingfx, Swingfx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Effect added";


                bool swap6 = Engine.Convert(offsetpick, pickaxepath, Impactfx, Impactfx1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Effect added";


                bool swap7 = Engine.Convert(offsetpick, pickaxepath, Idlefx, Idlefx1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Idle Effect added";


                bool swap8 = Engine.Convert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Icon added";

                long offset_current = Settings.Default.current_offset;
                bool swap9 = Engine.Convert(offset_current, pickaxepath, fx, fx1, 0, 0, false, false);
                if (swap9)
                    RichTextBoxInfo.Text += "\n[LOG] Base Effect added";


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
                    Settings.Default.ACDCEnabled = false;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Revert(offsetpick, pickaxepath, Equip, Equip1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound removed";

                bool swap3 = Engine.Revert(offsetpick, pickaxepath, Swing, Swing1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Sound removed!";

                bool swap4 = Engine.Revert(offsetpick, pickaxepath, Impact, Impact1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Sound removed";

                bool swap5 = Engine.Revert(offsetpick, pickaxepath, Swingfx, Swingfx1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Swing Effect removed";


                bool swap6 = Engine.Revert(offsetpick, pickaxepath, Impactfx, Impactfx1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Impact Effect removed";


                bool swap7 = Engine.Revert(offsetpick, pickaxepath, Idlefx, Idlefx1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Idle Effect removed";


                bool swap8 = Engine.Revert(offsetpick, pickaxepath, icon, icon1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Icon removed";

                long offset_current = Settings.Default.current_offset;
                bool swap9 = Engine.Revert(offset_current, pickaxepath, fx, fx1, 0, 0, false, false);
                if (swap9)
                    RichTextBoxInfo.Text += "\n[LOG] Base Effect removed";


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
