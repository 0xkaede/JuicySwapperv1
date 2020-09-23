using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class StarWand : Form
    {
        public StarWand()
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
            if (Properties.Settings.Default.StarWandEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/Meshes/Sweater_Weather_Male_Axe.Sweater_Weather_Male_Axe";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Pickaxe_StarWand/Meshes/Star_Wand_Axe.Star_Wand_Axe";
        string Idlefx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeatherMale_Idle.P_Pickaxe_SweaterWeatherMale_Idle";
        string Idlefx1 = "/Game/Weapons/FORT_Melee/Pickaxe_StarWand/FX/P_StarWand_PickAxe_Idle.P_StarWand_PickAxe_Idle";
        string Swingfx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeatherMale_Swing.P_Pickaxe_SweaterWeatherMale_Swing";
        string Swingfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_StarWand/FX/P_StarWand_PickAxe_Swing.P_StarWand_PickAxe_Swing";
        string Impactfx = "/Game/Weapons/FORT_Melee/Pickaxe_SweaterWeatherMale/FX/P_Pickaxe_SweaterWeather_Impact.P_Pickaxe_SweaterWeather_Impact";
        string Impactfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_StarWand/FX/P_StarWand_PickAxe_Impact.P_StarWand_PickAxe_Impact";
        string Swing = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Swing_Athena_Cue.PickAxe_SweaterWeatherMale_Swing_Athena_Cue";
        string Swing1 = "/Game/Athena/Sounds/Weapons/PickAxes/StarWand/PickAxe_StarWand_Swing_Athena_Cue.PickAxe_StarWand_Swing_Athena_Cue";
        string Impact = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Impact_Player_Athena_Cue.PickAxe_SweaterWeatherMale_Impact_Player_Athena_Cue";
        string Impact1 = "/Game/Athena/Sounds/Weapons/PickAxes/StarWand/PickAxe_StarWand_Impact_Player_Athena_Cue.PickAxe_StarWand_Impact_Player_Athena_Cue";
        string Equip = "/Game/Athena/Sounds/Weapons/PickAxes/SweaterWeather/PickAxe_SweaterWeatherMale_Ready_Athena_Cue.PickAxe_SweaterWeatherMale_Ready_Athena_Cue";
        string Equip1 = "/Game/Athena/Sounds/Weapons/PickAxes/StarWand/PickAxe_StarWand_Ready_Athena_Cue.PickAxe_StarWand_Ready_Athena_Cue";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SweaterWeatherPickaxe.T-Icon-Pickaxes-SweaterWeatherPickaxe";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-Star-Wand-Axe.T-Icon-Pickaxes-Star-Wand-Axe";


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
                    Settings.Default.StarWandEnabled = true;
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
                    Settings.Default.StarWandEnabled = false;
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

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
