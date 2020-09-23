using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Kyra : Form
    {
        public Kyra()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Street_Racer_Drift_Remix/Meshes/F_MED_Street_Racer_Drift_Remix_T2.F_MED_Street_Racer_Drift_Remix_T2";
        string Body1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Green_Jacket/Meshes/F_MED_Green_Jacket.F_MED_Green_Jacket";
        string AnimBP = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Street_Racer_Drift_Remix/Meshes/F_MED_Street_Racer_Drift_Remix_AnimBP.F_MED_Street_Racer_Drift_Remix_AnimBP_C";
        string AnimBP1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Green_Jacket/Meshes/F_MED_Green_Jacket_AnimBP.F_MED_Green_Jacket_AnimBP_C";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Femal1";
        string FaceAcc = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Street_Racer_Drift_Remix/Meshes/Parts/F_MED_SR_Drift_FaceAcc_T234.F_MED_SR_Drift_FaceAcc_T234";
        string FaceAcc1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Green_Jacket/Meshes/Parts/F_MED_Green_Jacket_FaceAcc.F_MED_Green_Jacket_FaceAcc";
        string FaceAccAnim = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Street_Racer_Drift_Remix/Meshes/Parts/F_MED_SR_Drift_FaceAcc_T234_AnimBP.F_MED_SR_Drift_FaceAcc_T234_AnimBP_C";
        string FaceAccAnim1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Green_Jacket/Meshes/Parts/F_MED_Green_Jacket_FaceAcc_AnimBP.F_MED_Green_Jacket_FaceAcc_AnimBP_C";


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
            if (Properties.Settings.Default.KyraEnabled == true)
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
            int SpecialFaceAccOffset = 65077713;




            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string hatpath = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            string cppath = Settings.Default.pakPath + "\\pakchunk10-WindowsClient.pak";
            if (convertButton.Text == "Convert")
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "Starting...";

                bool swap1 = Engine.Convert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    Settings.Default.KyraEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/3 added";
                }
                long Offset_current = Settings.Default.current_offset - 294;
                bool swap2 = Engine.Convert(Offset_current, bodypath, AnimBP, AnimBP1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/3 added";

                Offset_current = Settings.Default.current_offset + 1001;
                bool swap3 = Engine.Convert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 added";

                Offset_current = Settings.Default.current_offset - 3104;
                bool swap8 = Engine.Convert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap8)
                { }

                Offset_current = Settings.Default.current_offset + 8204;
                bool swap9 = Engine.Convert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap9)
                { }

                Offset_current = Settings.Default.current_offset + 4936;
                bool swap10 = Engine.Convert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap10)
                { }

                bool swap4 = Engine.Convert(SpecialFaceAccOffset, headpath, FaceAcc, FaceAcc1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Face 1/2 added";

                long faceanim = SpecialFaceAccOffset + 285;
                bool swap5 = Engine.Convert(faceanim, headpath, FaceAccAnim, FaceAccAnim1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Face 2/2 added";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                convertButton.Text = "Revert";
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "Starting...";

                bool swap1 = Engine.Revert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    Settings.Default.KyraEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/3 removed";
                }
                long Offset_current = Settings.Default.current_offset - 294;
                bool swap2 = Engine.Revert(Offset_current, bodypath, AnimBP, AnimBP1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/3 removed";

                Offset_current = Settings.Default.current_offset + 1001;
                bool swap3 = Engine.Revert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 removed";

                Offset_current = Settings.Default.current_offset - 3104;
                bool swap8 = Engine.Revert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap8)
                { }

                Offset_current = Settings.Default.current_offset + 8204;
                bool swap9 = Engine.Revert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap9)
                { }

                Offset_current = Settings.Default.current_offset + 4936;
                bool swap10 = Engine.Revert(Offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap10)
                { }

                bool swap4 = Engine.Revert(SpecialFaceAccOffset, headpath, FaceAcc, FaceAcc1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Face 1/2 removed";

                long faceanim = SpecialFaceAccOffset + 285;
                bool swap5 = Engine.Revert(faceanim, headpath, FaceAccAnim, FaceAccAnim1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Face 2/2 removed";

                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                convertButton.Text = "Convert";
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
