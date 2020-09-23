using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class FireVortex : Form
    {
        public FireVortex()
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
            if (Properties.Settings.Default.FireVortexEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        string Mesh = "/Game/Accessories/FORT_Backpacks/M_MED_FurnaceFace_Backpack/Meshes/M_MED_Furnace_Face_Backpack.M_MED_Furnace_Face_Backpack";
        string Mesh1 = "/Game/Accessories/FORT_Backpacks/M_MED_Kurohomura_Backpack/Meshes/M_MED_Kurohomura_Pack.M_MED_Kurohomura_Pack";
        string FX = "/Game/Accessories/FORT_Backpacks/M_MED_FurnaceFace_Backpack/FX/CCPM_Backpack_Furnace_Face.CCPM_Backpack_Furnace_Face_C";
        string FX1 = "/Game/Accessories/FORT_Backpacks/M_MED_Kurohomura_Backpack/BP_Backpack_Kurohomura.BP_Backpack_Kurohomura_C";
        string BID = "/Game/Athena/Items/Cosmetics/Backpacks/BID_242_FurnaceFace.BID_242_FurnaceFace";
        string BID1 = "/Game/Athena/Items/Cosmetics/Backpacks/BID_363_Kurohomura.BID_363_Kurohomura";


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
            //int offsetid = 525000000;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            string idpath = Settings.Default.pakPath + Settings.Default.idpathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";


                bool swap1 = Engine.Convert(offsetback, backblingpath, Mesh, Mesh1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Mesh added";
                    Settings.Default.FireVortexEnabled = true;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Convert(offsetback, backblingpath, FX, FX1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] FX added";
                }

                bool swap3 = Engine.Convert(offsetlobby, idpath, BID, BID1, 0, 0, false, false);
                if (swap3)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Backbling ID added!";
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

                bool swap1 = Engine.Revert(offsetback, backblingpath, Mesh, Mesh1, 0, 0, false, false);
                if (swap1)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Mesh removed";
                    Settings.Default.FireVortexEnabled = false;
                    Settings.Default.Save();
                }

                bool swap2 = Engine.Revert(offsetback, backblingpath, FX, FX1, 0, 0, false, false);
                if (swap2)
                {
                    RichTextBoxInfo.Text += "\n[LOG] FX removed";
                }

                bool swap3 = Engine.Revert(offsetlobby, idpath, BID, BID1, 0, 0, false, false);
                if (swap3)
                {
                    RichTextBoxInfo.Text += "\n[LOG] Backbling ID removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
