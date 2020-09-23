using DiscordRPC;
using JuicySwapper.Properties;
using MS.WindowsAPICodePack.Internal;
using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("704324460291031047");
        public Loader()
        {
            Juicy.discordrpc.Initialize();
            Juicy.SetDiscordAction("Loading Swapper...");
            InitializeComponent();
            RequestInvite();
            RequestOffset();
            RequestPaks();
            timer2.Start();
        }
        private static string GetTextFromUrl(string url)
        {
            WebClient wc = new WebClient();
            string page = wc.DownloadString(url);
            return page;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            RequestFortniteClose();
            Form form = new Home();
            var Open = form;
            Open.Closed += (s, args) => this.Close();
            this.Hide();
            Open.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loaderProgressBar.Value += 5;
            if (loaderProgressBar.Value == 100)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private static void RequestOffset()
        {
            try
            {
                string Offset = GetTextFromUrl("https://juicyswapper.xyz/api/offsets");
                string CPOffset = GetTextFromUrl("https://juicyswapper.xyz/api/cpoffsets");
                var result = Regex.Split(Offset, "\r\n|\r|\n");
                var cpresult = Regex.Split(CPOffset, "\r\n|\r|\n");
                Settings.Default.offsetskin1 = int.Parse(result[0]); //offset body
                Settings.Default.offsetskin2 = int.Parse(result[1]); //offset head
                Settings.Default.offsetpick = int.Parse(result[2]); //offset pickaxe mesh
                Settings.Default.offsetpickmesh = int.Parse(result[3]); //offset pickaxe sound
                Settings.Default.offsetback = int.Parse(result[4]); //offset backbling
                Settings.Default.offsetemote = int.Parse(result[5]); //offset emote_CMM
                Settings.Default.offsetlobby = int.Parse(result[6]); //offset lobby
                //
                //OFFSETS 13+
                //
                Settings.Default.offsetbody13 = int.Parse(result[7]); //offset Body 13+
                Settings.Default.offsethead13 = int.Parse(result[8]); //offset Head 13+
                //
                //CP SKIN OFFSETS
                //
                Settings.Default.defaultbody = int.Parse(cpresult[0]); //offset cp body
                Settings.Default.defaulthead = int.Parse(cpresult[1]); //offset cp head
                Settings.Default.invalidm = int.Parse(cpresult[2]); //offset invalid RebirthDefault (M) 
                Settings.Default.invalidf = int.Parse(cpresult[3]); //offset invalid RebirthDefaultA (F)
                Settings.Default.Save();
            }
            catch (Exception rr)
            {
                MessageBox.Show("Couldn't retrieve offsets from Juicy Server! Please contact Juicy Swapper Support.\nException Message: " + rr);
            }
        }

        private static void RequestPaks()
        {
            try
            {
                string Paks = GetTextFromUrl("https://juicyswapper.xyz/api/paks");
                string CP_Paks = GetTextFromUrl("https://juicyswapper.xyz/api/pakscp");
                var result = Regex.Split(Paks, "\r\n|\r|\n");
                var cpresult = Regex.Split(CP_Paks, "\r\n|\r|\n");
                Settings.Default.bodypathAPI = (result[0]); //Body Pak
                Settings.Default.headpathAPI = (result[1]); //Head Pak
                Settings.Default.pickaxepathAPI = (result[2]); //Pickaxe sound Pak
                Settings.Default.pickaxesoundpathAPI = (result[3]); //Pickaxe sound Pak
                Settings.Default.backblingpathAPI = (result[4]); //BackBling Pak
                Settings.Default.emotespathAPI = (result[5]); //Emote Pak
                Settings.Default.idpathAPI = (result[6]); //Pak Lobby
                //
                //PAKS 13+
                //
                Settings.Default.body13pathAPI = (result[7]); //pak body 13+
                Settings.Default.head13pathAPI = (result[8]); //Pak head 13+
                Settings.Default.Save();
                //
                //CP SKIN PAKS
                //
                Settings.Default.cppackAPI2 = (cpresult[0]); //Body Pak
                Settings.Default.cppackAPI = (cpresult[1]); //Head Pak
                Settings.Default.Save();
            }
            catch (Exception rr)
            {
                MessageBox.Show("Couldn't retrieve Paks from Juicy Server! Please contact Juicy Swapper Support.\nException Message: " + rr);
            }
        }

        private static void RequestFortniteClose()
        {
            Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
                MessageBox.Show("Closed Fortnite! Please do not have Fortnite open whilst using Juicy Swapper.\nPress OK to continue.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("EpicGamesLauncher");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("UnrealCEFSubProcess");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteLauncher");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("EasyAntiCheat");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("umodel");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        private static void RequestInvite()
        {
            if (Properties.Settings.Default.opendiscord == true)
            {
                //System.Diagnostics.Process.Start("http://juicyswapper.xyz/discord");
            }
        }
    }
}
