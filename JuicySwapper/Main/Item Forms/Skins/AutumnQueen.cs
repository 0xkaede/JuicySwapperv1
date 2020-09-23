using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class AutumnQueen : Form
    {
        public AutumnQueen()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            MessageBox.Show("This skin uses Tier 1 of Rox. Please select this style before swapping Autumn Queen.");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string PakFolder = Properties.Settings.Default.pakPath;

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath9 = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";

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
            if (Properties.Settings.Default.AutumnQueenEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Strawberry_Pilot/Meshes/F_MED_StrawberryPilot_T1_Body.F_MED_StrawberryPilot_T1_Body";
        string Body1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Forest_Queen/Meshes/F_MED_Forest_Queen.F_MED_Forest_Queen";
        string BodyBP = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Strawberry_Pilot/Meshes/F_MED_StrawberryPilot_AnimBP.F_MED_StrawberryPilot_AnimBP_C";
        string BodyBP1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Forest_Queen/Meshes/F_MED_Forest_Queen_AnimBp.F_MED_Forest_Queen_AnimBp_C";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Femal1";
        string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Strawberry_Pilot/Meshes/Parts/F_MED_StrawberryPilot_LongHair_FaceAcc.F_MED_StrawberryPilot_LongHair_FaceAcc";
        string Head1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Forest_Queen/Meshes/Parts/F_MED_Forest_Queen_FaceAcc.F_MED_Forest_Queen_FaceAcc";
        string HeadBP = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Strawberry_Pilot/Meshes/Parts/F_MED_StrawberryPilot_LongHair_FaceAcc_AnimBP.F_MED_StrawberryPilot_LongHair_FaceAcc_AnimBP_C";
        string HeadBP1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Forest_Queen/Meshes/Parts/F_MED_Forest_Queen_FaceAcc_AnimBp.F_MED_Forest_Queen_FaceAcc_AnimBp_C";
        string FaceAcc = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Strawberry_Pilot/Materials/MI_F_Strawberry_Pilot_Head.MI_F_Strawberry_Pilot_Head";
        string FaceAcc1 = "/Game/Characters/Player/Female/Medium/Heads/F_MED_Forest_Queen/Materials/MI_F_MED_Forest_Queen_Head.MI_F_MED_Forest_Queen_Head";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; int offsetskin1 = Settings.Default.offsetskin1; int offsetpick = Settings.Default.offsetpick; int offsetback = Settings.Default.offsetback; int offsetskin2 = Settings.Default.offsetskin2; int offsetemote = Settings.Default.offsetemote; int offsetlobby = Settings.Default.offsetlobby; int offsetpickmesh = Settings.Default.offsetpickmesh;



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

                bool swap1 = Engine.Convert(offsetskin1, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added!";
                    Settings.Default.AutumnQueenEnabled = true;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Convert(offsetskin1, bodypath, BodyBP, BodyBP1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added!";
                }

                long offset_current = Settings.Default.current_offset;
                bool swap3 = Engine.Convert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 added!";

                bool swap4 = Engine.Convert(offsetskin2, headpath, Head, Head1, 0, 0, false, false);
                if (swap4)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 added!";
                }

                bool swap5 = Engine.Convert(offsetskin2, headpath, HeadBP, HeadBP1, 0, 0, false, false);
                if (swap5)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 added";
                }

                bool swap6 = Engine.Convert(offsetskin2, headpath, FaceAcc, FaceAcc1, 0, 0, false);
                if (swap6)
                {
                    RichTextBoxInfo.Text += "\n[LOG] FaceAcc added!";
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

                bool swap1 = Engine.Revert(offsetskin1, bodypath, Body, Body1, 0, 0, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/3 removed!";
                    Settings.Default.AutumnQueenEnabled = false;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Revert(offsetskin1, bodypath, BodyBP, BodyBP1, 0, 0, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/3 removed!";
                }

                long offset_current = Settings.Default.current_offset;
                bool swap3 = Engine.Revert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Body 3/3 removed!";

                bool swap4 = Engine.Revert(offsetskin2, headpath, Head, Head1, 0, 0, false);
                if (swap4)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 removed!";
                }

                bool swap5 = Engine.Revert(offsetskin2, headpath, HeadBP, HeadBP1, 0, 0, false);
                if (swap5)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 removed!";
                }

                bool swap6 = Engine.Revert(offsetskin2, headpath, FaceAcc, FaceAcc1, 0, 0, false);
                if (swap6)
                {
                    RichTextBoxInfo.Text += "\n[LOG] FaceAcc removed!";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
