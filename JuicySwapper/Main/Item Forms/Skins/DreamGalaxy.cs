using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class DreamGalaxy : Form
    {
        public DreamGalaxy()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Metaverse/Materials/MI_F_Metaverse_Body.MI_F_Metaverse_Body";
        string Body1 = "/Game/Weapons/FORT_Melee/Materials/MI_FORT_Melee_Pick_Celestial.MI_FORT_Melee_Pick_Celestial";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Femal1";
        string SBase = "/Game/Characters/Player/Female/Medium/Base/SK_M_Female_Base_Skeleton.SK_M_Female_Base_Skeleton";
        string SBase1 = "/Game/Characters/Player/Male/Medium/Base/SK_M_MALE_Base_Skeleton.SK_M_MALE_Base_Skeleton";
        string BodyMesh = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Meshes/F_Med_Soldier_01.F_Med_Soldier_01";
        string BodyMesh1 = "/Game/Characters/Player/Male/Medium/Bodies/M_MED_Bronto/Meshes/M_MED_Bronto.M_MED_Bronto";
        string BodyAnim = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Meshes/F_Med_Soldier_01_Skeleton_AnimBP.F_Med_Soldier_01_Skeleton_AnimBP_C";
        string BodyAnim1 = "/Game/Characters/Player/Male/Medium/Bodies/M_MED_Bronto/Meshes/M_MED_Bronto_Skeleton_AnimBlueprint.M_MED_Bronto_Skeleton_AnimBlueprint_C";
        string FX = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Metaverse/FX/CCPM_Female_ShatterFly_Light.CCPM_Female_ShatterFly_Light_C";
        string FX1 = "/Game/Effects/Fort_Effects/Effects/Characters/Athena_Parts/CCPM_Celeste_Loop.CCPM_Celeste_Loop_C";
        string Hair = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Metaverse/Materials/MI_F_Metaverse_Hair.MI_F_Metaverse_Hair";
        string Hair1 = "/Game/Gadgets/Assets/VinderTech_GliderChute/Glider_Deco/Materials/MI_Glider_Deco.MI_Glider_Deco";
        string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Metaverse/Materials/MI_F_Metaverse_Head.MI_F_Metaverse_Head";
        string Head1 = "/Game/Weapons/FORT_Melee/Materials/MI_FORT_Melee_Pick_Celestial.MI_FORT_Melee_Pick_Celestial";
        string HeadMesh = "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Sarah_Head_01/Meshes/F_MED_ASN_Sarah_Head_01.F_MED_ASN_Sarah_Head_01";
        string HeadMesh1 = "/Game/Characters/Player/Male/Medium/Heads/M_MED_HIS_Sparks_Head_01/Mesh/M_MED_HIS_Sparks_Head_01.M_MED_HIS_Sparks_Head_01";
        


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
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
            if (Properties.Settings.Default.DreamGalaxyEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

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


            
            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string hatpath = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            if (convertButton.Text == "Convert")
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "Starting...";

                bool swap1 = Engine.Convert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    Settings.Default.DreamGalaxyEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/5 added";
                }
                long Offset_current = Settings.Default.current_offset + 709;
                bool swap2 = Engine.Convert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/5 added";
                Offset_current = Settings.Default.current_offset - 1655;
                bool swap3 = Engine.Convert(Offset_current, bodypath, SBase, SBase1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/5 added";

                Offset_current = Settings.Default.current_offset;
                bool swap4 = Engine.Convert(Offset_current, bodypath, BodyMesh, BodyMesh1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Body 4/5 added";

                Offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Convert(Offset_current, bodypath, BodyAnim, BodyAnim1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Body 5/5 added";

                Offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Convert(Offset_current, bodypath, FX, FX1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Effect added";

                bool swap7 = Engine.Convert(Offset_Skin_Head, headpath, Hair, Hair1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Hair added";

                bool swap8 = Engine.Convert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 added";

                Offset_current = Settings.Default.current_offset;
                bool swap9 = Engine.Convert(Offset_current, headpath, HeadMesh, HeadMesh1, 0, 0, false, false);
                if (swap9)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 added";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                convertButton.Text = "Revert";
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                convertButton.Enabled = false;
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "Starting...";

                bool swap1 = Engine.Revert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    Settings.Default.DreamGalaxyEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/5 removed!";
                }
                long Offset_current = Settings.Default.current_offset + 709;
                bool swap2 = Engine.Revert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/5 removed";

                Offset_current = Settings.Default.current_offset - 1655;
                bool swap3 = Engine.Revert(Offset_current, bodypath, SBase, SBase1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/5 removed";

                Offset_current = Settings.Default.current_offset;
                bool swap4 = Engine.Revert(Offset_current, bodypath, BodyMesh, BodyMesh1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Body 4/5 removed";

                Offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Revert(Offset_current, bodypath, BodyAnim, BodyAnim1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Body 5/5 removed";

                Offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Revert(Offset_current, bodypath, FX, FX1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Effect removed";

                bool swap7 = Engine.Revert(Offset_Skin_Head, headpath, Hair, Hair1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Hair removed";

                bool swap8 = Engine.Revert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 removed";

                Offset_current = Settings.Default.current_offset;
                bool swap9 = Engine.Revert(Offset_current, headpath, HeadMesh, HeadMesh1, 0, 0, false, false);
                if (swap9)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 removed";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                convertButton.Text = "Convert";
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
