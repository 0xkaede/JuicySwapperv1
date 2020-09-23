using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Flapper : Form
    {
        public Flapper()
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
            if (Properties.Settings.Default.FlapperEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        string CMM = "/Game/Animation/Game/MainPlayer/Emotes/GrooveJam/Emote_GrooveJam_CMM_M.Emote_GrooveJam_CMM_M";
        string CMM1 = "/Game/Animation/Game/MainPlayer/Emotes/Emote_Charleston_M.Emote_Charleston_M";
        string CMF = "/Game/Animation/Game/MainPlayer/Emotes/GrooveJam/Emote_GrooveJam_CMF_M.Emote_GrooveJam_CMF_M";
        string CMF1 = "/Game/Animation/Game/MainPlayer/Emotes/Emote_Charleston_M.Emote_Charleston_M";



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
                convertButton.Enabled = false;
                RichTextBoxInfo.Text = "";
                RichTextBoxInfo.Text += "[LOG] Starting...";


                bool swap1 = Engine.Convert(offsetemote, emotespath, CMM, CMM1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Dance 1/2 added!";
                    Settings.Default.FlapperEnabled = true;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Convert(offsetemote, emotespath, CMF, CMF1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Dance 2/2 added!";
                }


                convertButton.Enabled = true;
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                convertButton.Enabled = false;
                RichTextBoxInfo.Text = "";
                RichTextBoxInfo.Text += "[LOG] Starting...";

                bool swap1 = Engine.Revert(offsetemote, emotespath, CMM, CMM1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Dance 1/2 removed!";
                    Settings.Default.FlapperEnabled = false;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Revert(offsetemote, emotespath, CMF, CMF1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Dance 2/2 removed!";
                }


                convertButton.Enabled = true;
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
