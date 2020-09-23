using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class NogOps : Form
    {
        public NogOps()
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
            if (Properties.Settings.Default.NogOpsEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string Body = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Female_Commando_StreetRacerBlack/Materials/F_MED___StreetRacerBlack.F_MED___StreetRacerBlack";
        string Body1 = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/BR_UglySweater/Materials/F_Med_Soldier_04_UglySweater.F_Med_Soldier_04_UglySweater";
        string Gender = "EFortCustomGender::Female";
        string Gender1 = "EFortCustomGender::Femal1";
        string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Female_Commando_StreetRacerBlack/Materials/F_MED_StreetRacerBlack_Head_01.F_MED_StreetRacerBlack_Head_01";
        string Head1 = "/Game/Characters/Player/Female/Medium/Bodies/F_Med_Soldier_01/Skins/Female_Commando_StreetRacerBlack/Materials/F_MED_StreetRacerBlack_Head_01.F_MED_StreetRacerBlack_Head000";
        string Headmesh = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01.F_MED_HIS_Ramirez_Head_01";
        string Headmesh1 = "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Sarah_Head_01/Meshes/F_MED_ASN_Sarah_Head_01.F_MED_ASN_Sarah_Head_01";
        string HeadmeshBP = "/Game/Characters/Player/Female/Medium/Heads/F_MED_HIS_Ramirez_Head_01/Mesh/F_MED_HIS_Ramirez_Head_01_AnimBP_Child.F_MED_HIS_Ramirez_Head_01_AnimBP_Child_C";
        string HeadmeshBP1 = "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Sarah_Head_01/Meshes/F_MED_ASN_Sarah_Head_01_AnimBP_Child.F_MED_ASN_Sarah_Head_01_AnimBP_Child_C";
        string Hat = "/Game/Accessories/Hats/Materials/Hat_F_StreetRacerBlack.Hat_F_StreetRacerBlack";
        string Hat1 = "/Game/Accessories/Hats/Materials/Hat_F_StreetRacerBlack.Hat_F_StreetRacerBl000";
        string Hatmat = "/Game/Accessories/Hats/Mesh/Female_Outlander_06.Female_Outlander_06";
        string Hatmat1 = "/Game/Accessories/Hats/Mesh/Female_Commando_08.Female_Commando_08";


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

                bool swap1 = Engine.Convert(Offset_Skin_Body, bodypath, Body, Body1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Body 1/2 added";
                    Settings.Default.NogOpsEnabled = true;
                    Settings.Default.Save();
                }


                long offset_current = Settings.Default.current_offset;
                bool swap2 = Engine.Convert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 added";

                bool swap4 = Engine.Convert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/3 added";

                offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Convert(offset_current, headpath, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/3 added";

                offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Convert(offset_current, headpath, HeadmeshBP, HeadmeshBP1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/3 added";

                offset_current = Settings.Default.current_offset;
                bool swap7 = Engine.Convert(Offset_Skin_Head, headpath, Hat, Hat1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Hat 1/2 added";

                offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Convert(offset_current, headpath, Hatmat, Hatmat1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Hat 2/2 added";
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
                    Settings.Default.NogOpsEnabled = false;
                    Settings.Default.Save();
                }


                long offset_current = Settings.Default.current_offset;
                bool swap2 = Engine.Revert(offset_current, bodypath, Gender, Gender1, 0, 0, false, false);
                if (swap2)
                    RichTextBoxInfo.Text += "\n[LOG] Body 2/2 removed";

                offset_current = Settings.Default.current_offset;
                bool swap4 = Engine.Revert(Offset_Skin_Head, headpath, Head, Head1, 0, 0, false, false);
                if (swap4)
                    RichTextBoxInfo.Text += "\n[LOG] Head 1/3 removed";

                offset_current = Settings.Default.current_offset;
                bool swap5 = Engine.Revert(offset_current, headpath, Headmesh, Headmesh1, 0, 0, false, false);
                if (swap5)
                    RichTextBoxInfo.Text += "\n[LOG] Head 2/3 removed";

                offset_current = Settings.Default.current_offset;
                bool swap6 = Engine.Revert(offset_current, headpath, HeadmeshBP, HeadmeshBP1, 0, 0, false, false);
                if (swap6)
                    RichTextBoxInfo.Text += "\n[LOG] Head 3/3 removed";

                offset_current = Settings.Default.current_offset;
                bool swap7 = Engine.Revert(offset_current, headpath, Hat, Hat1, 0, 0, false, false);
                if (swap7)
                    RichTextBoxInfo.Text += "\n[LOG] Hat 1/2 removed";

                offset_current = Settings.Default.current_offset;
                bool swap8 = Engine.Revert(offset_current, headpath, Hatmat, Hatmat1, 0, 0, false, false);
                if (swap8)
                    RichTextBoxInfo.Text += "\n[LOG] Hat 2/2 removed";
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
