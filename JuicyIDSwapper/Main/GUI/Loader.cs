using DiscordRPC;
using JuicyIDSwapper.Properties;
using MS.WindowsAPICodePack.Internal;
using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("732652012826525706");
        public Loader()
        {
            Juicy.discordrpc.Initialize();
            Juicy.SetDiscordAction("Loading ID Swapper...");
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
                var result = Regex.Split(Offset, "\r\n|\r|\n");
                Settings.Default.offsetlobby = int.Parse(result[6]); //offset lobby
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
                var result = Regex.Split(Paks, "\r\n|\r|\n");
                Settings.Default.idpathAPI = (result[6]); //Pak Lobby
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
            Process.Start("http://juicyswapper.xyz/discord");
        }
    }
}
