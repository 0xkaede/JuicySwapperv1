using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class ReconSpecialist : Form
    {
        public ReconSpecialist()
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
            if (Properties.Settings.Default.ReconSpecialistEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        string Offset = "/Game/Characters/CharacterParts/Female/Medium/Bodies/F_Med_Soldier_SonyEx_BR";
        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/BR_SonyEx/Materials/F_MED_Commando_Body_SonyEx.F_MED_Commando_Body_SonyEx";
        string Body1 = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/CM_01/Materials/F_MED_Commando_Body_CM01.F_MED_Commando_Body_CM01";
        string Hat = "/Game/Accessories/Hats/Materials/Hat_F_Commando_03_V01.Hat_F_Commando_03_V01";
        string Hat1 = "/Game/Accessories/Hats/Materials/Hat_F_Commando_03.Hat_F_Commando_03";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Fem000";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int Offset_Skin_Body = Settings.Default.offsetskin2;


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string path = Settings.Default.pakPath + Settings.Default.headpathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";
                bool swap = Engine.Convert(Offset_Skin_Body, path, Offset, Offset, 0, 0, false, false);
                if (swap)
                {

                }

                long currentoffset = Settings.Default.current_offset;
                bool swap1 = Engine.Convert(currentoffset, path, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                    Settings.Default.ReconSpecialistEnabled = true;
                    Settings.Default.Save();
                }

                long offset_current = Settings.Default.current_offset + 685;
                bool swap2 = Engine.Convert(offset_current, path, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";
                }

                bool swap3 = Engine.Convert(Offset_Skin_Body, path, Hat, Hat1, 0, 0, false, false);
                if (swap3)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hat added";
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
                bool swap = Engine.Revert(Offset_Skin_Body, path, Offset, Offset, 0, 0, false, false);
                if (swap)
                {

                }

                long currentoffset = Settings.Default.current_offset;
                bool swap1 = Engine.Revert(currentoffset, path, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 removed";
                    Settings.Default.ReconSpecialistEnabled = false;
                    Settings.Default.Save();
                }

                long offset_current = Settings.Default.current_offset + 685;
                bool swap2 = Engine.Revert(offset_current, path, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";
                }

                bool swap3 = Engine.Revert(Offset_Skin_Body, path, Hat, Hat1, 0, 0, false, false);
                if (swap3)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Hat removed";
                }
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
