using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Galaxy : Form
    {
        public Galaxy()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string PakFolder = Properties.Settings.Default.pakPath;

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath = Settings.Default.pakPath + "\\pakchunk10_s3-WindowsClient.pak";

            if (!File.Exists(filePath))
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
            if (Properties.Settings.Default.GalaxyEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string BodyMaterial = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Aurora_Glow/Materials/M_F_Med_Soldier_01_AuroraGlow.M_F_Med_Soldier_01_AuroraGlow";
        string BodyMaterial1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/Galaxy/Materials/M_Med_Soldier_04_Celestial.M_Med_Soldier_04_Celestial";
        string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Aurora_Glow/Materials/F_MED_Commando_Head_01_AuroraGlow.F_MED_Commando_Head_01_AuroraGlow";
        string Head1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/Galaxy/Materials/M_MED_HIS_Sparks_Hair_Celestial.M_MED_HIS_Sparks_Hair_Celestial";
        string Hair = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Aurora_Glow/Materials/F_MED_Commando_Hair_01_AuroraGlow.F_MED_Commando_Hair_01_AuroraGlow";
        string Hair1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/Galaxy/Materials/M_MED_HIS_Sparks_Head_Celestial.M_MED_HIS_Sparks_Head_Celestial";
        string Headmesh = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01.F_MED_HIS_Ramirez_Head_01";
        string Headmesh1 = "/Game/Characters/Player/Male/Medium/Heads/M_MED_HIS_Sparks_Head_01/Mesh/M_MED_HIS_Sparks_Head_01.M_MED_HIS_Sparks_Head_01";
        string HeadAnimBP = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01_AnimBP_Child.F_MED_HIS_Ramirez_Head_01_AnimBP_Child_C";
        string HeadAnimBP1 = "/Game/Characters/Player/Male/Medium/Heads/M_MED_HIS_Sparks_Head_01/Mesh/M_MED_HIS_Sparks_Head_01_AnimBP_Child.M_MED_HIS_Sparks_Head_01_AnimBP_Child_C";
        string Hat = "/Game/Accessories/Glasses/Meshes/Female_Commando_Shades.Female_Commando_Shades";
        string Hat1 = "/Game/Accessories/Hats/Mesh/Hat_Empty.Hat_Empty";

        private static byte[] Offset = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,77,95,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };
        private static byte[] Body = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,77,101,115,104,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,46,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49
        };
        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,69,68,95,66,114,111,110,116,111,47,77,101,115,104,101,115,47,77,95,77,69,68,95,66,114,111,110,116,111,46,77,95,77,69,68,95,66,114,111,110,116,111,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };
        private static byte[] BodyAnim = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,77,101,115,104,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,80,46,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,80,95,67
        };
        private static byte[] BodyAnim1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,69,68,95,66,114,111,110,116,111,47,77,101,115,104,101,115,47,77,95,77,69,68,95,66,114,111,110,116,111,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,46,77,95,77,69,68,95,66,114,111,110,116,111,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,95,67
        };
        private static byte[] Gender = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,101
        };
        private static byte[] Gender1 = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,49
        };

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
            string hatpath = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream swap1 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap1, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb - 366L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Body1);
                    binaryWriter.Close();
                    Settings.Default.GalaxyEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body Mesh added";
                }

                Stream swap2 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap2, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb - 145L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body Animation added";
                }

                Stream swap3 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap3, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb + 854L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Gender added";
                }

                bool swap4 = Engine.Convert(Offset_Skin_Body, bodypath, BodyMaterial, BodyMaterial1, 0, 0, false, false);
                if (swap4)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body Material added";
                }

                bool swap5 = Engine.Convert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap5)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/3 added";
                }
                long offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Convert(offset_current, headpath, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap6)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/3 added";
                }

                bool swap7 = Engine.Convert(offset_current, headpath, HeadAnimBP, HeadAnimBP1, 0, 0, false, false);
                if (swap7)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/3 added";
                }

                bool swap8 = Engine.Convert(Offset_Skin_Head, hatpath, Hat, Hat1, 0, 0, false, false);
                if (swap8)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hat added";
                }

                bool swap9 = Engine.Convert(Offset_Skin_Head, hatpath, Hair, Hair1, 0, 0, false, false);
                if (swap9)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hair added";
                }

                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream swap1 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap1, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb - 366L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Body);
                    binaryWriter.Close();
                    Settings.Default.GalaxyEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body Mesh removed";
                }

                Stream swap2 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap2, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb - 145L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body Animation removed";
                }

                Stream swap3 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap3, 0, (long)Offset_Skin_Body, Offset))
                {
                    swap3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb + 356L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Gender removed";
                }

                bool swap4 = Engine.Revert(Offset_Skin_Body, bodypath, BodyMaterial, BodyMaterial1, 0, 0, false, false);
                if (swap4)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body Material removed";
                }

                bool swap5 = Engine.Revert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap5)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/3 removed";
                }
                long offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Revert(offset_current, headpath, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap6)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/3 removed";
                }

                bool swap7 = Engine.Revert(offset_current, headpath, HeadAnimBP, HeadAnimBP1, 0, 0, false, false);
                if (swap7)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/3 removed";
                }

                bool swap8 = Engine.Revert(Offset_Skin_Head, hatpath, Hat, Hat1, 0, 0, false, false);
                if (swap8)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hat removed";
                }

                bool swap9 = Engine.Revert(Offset_Skin_Head, hatpath, Hair, Hair1, 0, 0, false, false);
                if (swap9)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hair removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
