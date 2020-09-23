using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class RenegadeRaiderCMat : Form
    {
        public RenegadeRaiderCMat()
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
            if (Properties.Settings.Default.RenegadeRaiderCEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_Body.MI_F_MED_Renegade_Raider_Fire_Body";
        string Body1 = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/TV_21/Materials/F_MED_Commando_Body_TV21.F_MED_Commando_Body_TV21";
        string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_Head.MI_F_MED_Renegade_Raider_Fire_Head";
        string Head1 = "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Sarah_Head_01/Materials/F_MED_ASN_Sarah_Head_02.F_MED_ASN_Sarah_Head_02";
        string FaceAcc = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_FaceAcc.MI_F_MED_Renegade_Raider_Fire_FaceAcc";
        string FaceAcc1 = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_FaceAcc.MI_F_MED_Renegade_Raider_Fire_Face000";
        string FX = "B_CCPM_Base_Niagara_RenegadeRaider_Fire.B_CCPM_Base_Niagara_RenegadeRaider_Fire";
        string FX1 = "B_CCPM_Base_Niagara_RenegadeRaider_Fire.B_CCPM_Base_Niagara_RenegadeRaider_0000";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Fem000";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int Offset_Skin_Body = Settings.Default.offsetbody13;
            int Offset_Skin_Head = Settings.Default.offsethead13;


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string bodypath = Settings.Default.pakPath + Settings.Default.body13pathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.head13pathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Convert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                    Settings.Default.RenegadeRaiderCEnabled = true;
                    Settings.Default.Save();
                }

                long offset_current = Settings.Default.current_offset;
                bool swap2 = Engine.Convert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                bool swap3 = Engine.Convert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 added";

                offset_current = Settings.Default.current_offset;
                bool swap4 = Engine.Convert(offset_current, headpath, FaceAcc, FaceAcc1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 added";

                bool swap5 = Engine.Convert(Offset_Skin_Body, bodypath, FX, FX1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Effects removed";

                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Revert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                    Settings.Default.RenegadeRaiderCEnabled = false;
                    Settings.Default.Save();
                }

                long offset_current = Settings.Default.current_offset;
                bool swap2 = Engine.Revert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";

                bool swap3 = Engine.Revert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap3)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/2 removed";

                offset_current = Settings.Default.current_offset;
                bool swap4 = Engine.Revert(offset_current, headpath, FaceAcc, FaceAcc1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/2 removed";

                bool swap5 = Engine.Revert(Offset_Skin_Body, bodypath, FX, FX1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Effects restored";

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
