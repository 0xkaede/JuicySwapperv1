using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class SkullTrooper : Form
    {
        public SkullTrooper()
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
            if (Properties.Settings.Default.SkullTrooperEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }
        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        string Body = "/Game/Characters/Player/Male/Medium/Bodies/M_MED_Commando_Jonesy_Cube/Materials/M_M_COM__JONESY_CUBE_Body.M_M_COM__JONESY_CUBE_Body";
        string Body1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/HW01_Red/M_Med_Soldier_04_HW01_Red.M_Med_Soldier_04_HW01_Red";
        string Hair = "/Game/Characters/Player/Female/Medium/Heads/F_Med_Head_01/Materials/SciPop/F_MED_Commando_Hair_SciPop.F_MED_Commando_Hair_SciPop";
        string Hair1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/HW01_Glow/Male_Commando_HW01.Male_Commando_HW01";
        string HeadMat = "/Game/Characters/Player/Female/Medium/Heads/F_Med_Head_01/Materials/SciPop/F_MED_HIS_Ramirez_SciPop.F_MED_HIS_Ramirez_SciPop";
        string HeadMat1 = "/Game/Characters/Player/Male/Medium/Bodies/M_Med_Soldier_04/Skins/HW01_Glow/Male_Commando_HW01.Male_Commando_HW01";
        string Headmesh = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01.F_MED_HIS_Ramirez_Head_01";
        string Headmesh1 = "/Game/Characters/Player/Male/Medium/Bodies/M_MED_Donut/Meshes/Parts/Male_Medium_Donut_Head.Male_Medium_Donut_Head";
        string HeadmeshBP = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01_AnimBP_Child.F_MED_HIS_Ramirez_Head_01_AnimBP_Child_C";
        string HeadmeshBP1 = "/Game/Characters/Player/Male/Medium/Bodies/M_MED_Donut/Meshes/Parts/Male_Medium_Donut_Head_AnimBP_Child.Male_Medium_Donut_Head_AnimBP_Child_C";
        string BodyCP = "/Game/Athena/Heroes/Meshes/Bodies/CP_Athena_Body_M_OrnamentSoldier.CP_Athena_Body_M_OrnamentSoldier";
        string BodyCP1 = "/Game/Athena/Heroes/Meshes/Bodies/CP_Athena_Body_M_HalloweenAlt.CP_Athena_Body_M_HalloweenAlt";
        string HeadCP = "/Game/Characters/CharacterParts/FaceAccessories/CP_M_MED_OrnamentSoldier.CP_M_MED_OrnamentSoldier";
        string HeadCP1 = "/Game/Characters/CharacterParts/Hats/CP_Athena_Hat_M_HalloweenAlt.CP_Athena_Hat_M_HalloweenAlt";

        private static byte[] Test = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,69,68,95,79,114,97,110,103,101,95,67,97,109,111,47,77,101,115,104,101,115,47,77,95,77,69,68,95,79,114,97,110,103,101,95,67,97,109,111,95,66,111,100,121,46,77,95,77,69,68,95,79,114,97,110,103,101,95,67,97,109,111,95,66,111,100,121
        };

        private static byte[] CPBody = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,72,101,114,111,101,115,47,77,101,115,104,101,115,47,66,111,100,105,101,115,47,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65,46,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65
        };

        private static byte[] CPBody1 = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,72,101,114,111,101,115,47,77,101,115,104,101,115,47,66,111,100,105,101,115,47,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,67,117,98,101,80,97,105,110,116,74,111,110,101,115,121,46,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,67,117,98,101,80,97,105,110,116,74,111,110,101,115,121,0,0,0,0
        };

        private static byte[] CPHead = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,67,104,97,114,97,99,116,101,114,80,97,114,116,115,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,67,80,95,72,101,97,100,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65,46,67,80,95,72,101,97,100,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65
        };

        private static byte[] CPHead1 = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,72,101,114,111,101,115,47,77,101,115,104,101,115,47,72,101,97,100,115,47,70,95,77,101,100,95,72,105,115,95,82,97,109,105,114,101,122,95,72,101,97,100,95,83,99,105,80,111,112,95,65,84,72,46,70,95,77,101,100,95,72,105,115,95,82,97,109,105,114,101,122,95,72,101,97,100,95,83,99,105,80,111,112,95,65,84,72,0,0,0
        };

        private static byte[] Gender = new byte[]
        {
            0,0,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,79,114,110,97,109,101,110,116,83,111,108,100,105,101,114
        };

        private static byte[] Gender1 = new byte[]
        {
            0,0,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,74,117,105,99,121,73,110,118,97,108,105,100,48,48,48
        };


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int Offset_Skin_Body = Settings.Default.offsetskin1;
            int Offset_Skin_Head = Settings.Default.offsetskin2;


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string filePaths8 = Settings.Default.pakPath + "\\pakchunk10_s8-WindowsClient.pak";
            string filePathtest = Settings.Default.pakPath + "\\pakchunk10_s8-WindowsClient.pak";
            string filePath10 = Settings.Default.pakPath + "\\pakchunk10-WindowsClient.pak";
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream swap = File.OpenRead(filePath10);
                foreach (long numb in Researcher.FindPosition(swap, 0, Settings.Default.defaultbody, CPBody))
                {
                    swap.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath10, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(CPBody1);
                    binaryWriter.Close();
                    Settings.Default.SkullTrooperEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/3 added";
                }

                long offsetResearcher = Settings.Default.offsetskin1;

                Stream swap2 = File.OpenRead(filePathtest);
                foreach (long numb in Researcher.FindPosition(swap2, 0, offsetResearcher, Test))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePathtest, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb + 2912L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/3 added";
                }

                bool swap1 = Engine.Convert(Offset_Skin_Body, filePaths8, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 added";
                }

                Stream swaphead = File.OpenRead(filePath10);
                foreach (long numb in Researcher.FindPosition(swaphead, 0, Settings.Default.defaulthead, CPHead))
                {
                    swaphead.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath10, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(CPHead1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/5 added";
                }

                bool swap3 = Engine.Convert(Offset_Skin_Head, filePaths8, Hair, Hair1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/5 added";

                bool swap4 = Engine.Convert(Offset_Skin_Head, filePaths8, HeadMat, HeadMat1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/5 added";

                long offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Convert(offset_current, filePaths8, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Head 4/5 added";

                offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Convert(offset_current, filePaths8, HeadmeshBP, HeadmeshBP1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Head 5/5 added";
                //
                offset_current = Settings.Default.current_offset;
                bool swap7 = Engine.Convert(Offset_Skin_Head, filePaths8, BodyCP, BodyCP1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Character Part 1/2 added";

                offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Convert(offset_current, filePaths8, HeadCP, HeadCP1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Character Part 2/2 added";
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream swap = File.OpenRead(filePath10);
                foreach (long numb in Researcher.FindPosition(swap, 0, Settings.Default.defaultbody, CPBody1))
                {
                    swap.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath10, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(CPBody);
                    binaryWriter.Close();
                    Settings.Default.SkullTrooperEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/3 removed";
                }

                long offsetResearcher = Settings.Default.offsetskin1;

                Stream swap2 = File.OpenRead(filePathtest);
                foreach (long numb in Researcher.FindPosition(swap2, 0, offsetResearcher, Test))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePathtest, FileMode.Open, FileAccess.ReadWrite));
                    long offset = numb + 2912L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/3 removed";
                }

                bool swap1 = Engine.Revert(Offset_Skin_Body, filePaths8, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 removed";
                }

                Stream swaphead = File.OpenRead(filePath10);
                foreach (long numb in Researcher.FindPosition(swaphead, 0, Settings.Default.defaulthead, CPHead1))
                {
                    swaphead.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath10, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(CPHead);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/5 removed";
                }

                bool swap3 = Engine.Revert(Offset_Skin_Head, filePaths8, Hair, Hair1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/5 removed";

                bool swap4 = Engine.Revert(Offset_Skin_Head, filePaths8, HeadMat, HeadMat1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/5 removed";

                long offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Revert(offset_current, filePaths8, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Head 4/5 removed";

                offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Revert(offset_current, filePaths8, HeadmeshBP, HeadmeshBP1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Head 5/5 removed";

                bool swap7 = Engine.Revert(Offset_Skin_Head, filePaths8, BodyCP, BodyCP1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Character Part 1/2 removed";

                offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Revert(offset_current, filePaths8, HeadCP, HeadCP1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Character Part 2/2 removed";
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");
            }
        }
    }
}