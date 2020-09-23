using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;

namespace JuicySwapper.Main.Item.Pickaxes
{
    public partial class RaidersRevenge : Form
    {
        public RaidersRevenge()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static byte[] Swing1 = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,83,111,117,110,100,115,47,87,101,97,112,111,110,115,47,80,105,99,107,65,120,101,115,47,80,105,99,107,65,120,101,95,76,111,99,107,106,97,119,95,83,119,105,110,103,95,65,116,104,101,110,97,95,67,117,101,46,80,105,99,107,65,120,101,95,76,111,99,107,74,97,119,95,83,119,105,110,103,95,65,116,104,101,110,97,95,67,117,101
        };

        private static byte[] Swing = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,83,111,117,110,100,115,47,87,101,97,112,111,110,115,47,80,105,99,107,65,120,101,115,47,65,114,99,116,105,99,83,110,105,112,101,114,47,80,65,95,65,114,99,116,105,99,83,110,105,112,101,114,95,83,119,105,110,103,95,67,117,101,46,80,65,95,65,114,99,116,105,99,83,110,105,112,101,114,95,83,119,105,110,103,95,67,117,101,0
        };

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
            if (Properties.Settings.Default.RaidersRevengeEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Mesh = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/Meshes/Pickaxe_M_MED_ArcticSniper.Pickaxe_M_MED_ArcticSniper";
        string Mesh1 = "/Game/Weapons/FORT_Melee/Meshes/SK_Pickaxe_PostApocalyptic.SK_Pickaxe_PostApocalyptic";
        string Swingfx = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_Weapon.P_Melee_Arctic_Sniper_Weapon";
        string Swingfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_Weapon.P_Melee_Arctic_Sniper_Wea000";
        string Impactfx = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_Hit.P_Melee_Arctic_Sniper_Hit";
        string Impactfx1 = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_H00.P_Melee_Arctic_Sniper_H00";
        string Idlefx = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_FireTrail.P_Melee_Arctic_Sniper_FireTrail";
        string Idlefx1 = "/Game/Weapons/FORT_Melee/Pickaxe_ArcticSniper/FX/P_Melee_Arctic_Sniper_FireTr000.P_Melee_Arctic_Sniper_FireTr000";
        string icon = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-Pickaxe-ID-132-ArcticSniper.T-Icon-Pickaxes-Pickaxe-ID-132-ArcticSniper";
        string icon1 = "/Game/UI/Foundation/Textures/Icons/Weapons/Items/T-Icon-Pickaxes-SK-Pickaxe-PostApacolyptic.T-Icon-Pickaxes-SK-Pickaxe-PostApacolyptic";
        string ready = "/Game/Athena/Sounds/Weapons/PickAxes/ArcticSniper/PA_ArcticSniper_Ready_Cue.PA_ArcticSniper_Ready_Cue";
        string ready1 = "/Game/Athena/Sounds/Weapons/PickAxes/ArcticSniper/PA_ArcticSniper_Ready_Cue.PA_ArcticSniper_Ready_000";
        string impact = "/Game/Athena/Sounds/Weapons/PickAxes/ArcticSniper/PickAxe_ArcticSniper_Impact_Cue.PickAxe_ArcticSniper_Impact_Cue";
        string impact1 = "/Game/Sounds/Fort_Impact_Sounds/Flesh/Player_Impact_PA_LockJaw_Cue.Player_Impact_PA_LockJaw_Cue";


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
            string bodypath = Settings.Default.pakPath + "\\pakchunk10_s8-WindowsClient.pak";
            string headpath = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pickaxepath = Settings.Default.pakPath + "\\pakchunk10-WindowsClient.pak";
            string pickaxesoundpath = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string backblingpath = Settings.Default.pakPath + "\\pakchunk10-WindowsClient.pak";
            string emotespath = Settings.Default.pakPath + "\\pakchunk10-WindowsClient.pak";
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Convert(offsetpick, pickaxepath, Mesh, Mesh1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Mesh added";
                    Settings.Default.RaidersRevengeEnabled = true;
                    Settings.Default.Save();
                }

                Stream fs1 = File.OpenRead(pickaxepath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetpick, Swing))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(pickaxepath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(Swing1);
                    binaryWrite.Close();
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Swing Sound added";
                }
                bool swap3 = Engine.Convert(offsetpick, pickaxepath, ready, ready1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound added";

                bool swap4 = Engine.Convert(offsetpick, pickaxepath, impact, impact1, 0, 0, false, false);
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
                    Settings.Default.RaidersRevengeEnabled = false;
                    Settings.Default.Save();
                }

                Stream fs1 = File.OpenRead(pickaxepath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetpick, Swing1))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(pickaxepath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(Swing);
                    binaryWrite.Close();
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = "\n[LOG] Swing Sound removed";
                }
                bool swap3 = Engine.Revert(offsetpick, pickaxepath, ready, ready1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Equip Sound removed";

                bool swap4 = Engine.Revert(offsetpick, pickaxepath, impact, impact1, 0, 0, false, false);
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
