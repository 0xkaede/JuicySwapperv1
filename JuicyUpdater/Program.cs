using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using static Juicy_Swapper_v2.Classes.API.StatusAPI;
using Console = System.Console;

namespace Juicy_Updater
{
    class Program
    {
        static WebClient webclient = new WebClient();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Juicy Updater";
            foreach (Process process in Process.GetProcessesByName("Juicy Swapper v2.exe"))
            {
                process.Kill();
            }
            Title();
            Input("Checking for Juicy Swapper v2 updates...");
            Program.GetFileVer();
            Console.Read();
        }
        private static void Title()
        {
            System.Console.Clear();
            Colorful.Console.WriteLine();
            Colorful.Console.Write("                               █    ██  ██▓███  ▓█████▄  ▄▄▄     ▄▄▄█████▓▓█████  ██▀███  \n", Color.Orange);
            Colorful.Console.Write("                               ██  ▓██▒▓██░  ██▒▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒\n", Color.Orange);
            Colorful.Console.Write("                              ▓██  ▒██░▓██░ ██▓▒░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒\n", Color.Orange);
            Colorful.Console.Write("                              ▓▓█  ░██░▒██▄█▓▒ ▒░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄  \n", Color.Orange);
            Colorful.Console.Write("                              ▒▒█████▓ ▒██▒ ░  ░░▒████▓  ▓█   ▓██▒ ▒██▒ ░ ░▒████▒░██▓ ▒██▒\n", Color.Orange);
            Colorful.Console.Write("                              ░▒▓▒ ▒ ▒ ▒▓▒░ ░  ░ ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░\n", Color.Orange);
            Colorful.Console.Write("                              ░░▒░ ░ ░ ░▒ ░      ░ ▒  ▒   ▒   ▒▒ ░   ░     ░ ░  ░  ░▒ ░ ▒░\n", Color.Orange);
            Colorful.Console.Write("                               ░░░ ░ ░ ░░        ░ ░  ░   ░   ▒    ░         ░     ░░   ░ \n", Color.Orange);
            Colorful.Console.Write("                                 ░                 ░          ░  ░           ░  ░   ░     \n", Color.Orange);
            Colorful.Console.Write("\n");
        }

        public static void Input(string text)
        {
            Colorful.Console.Write(string.Format("                              [{0}] ", DateTime.Now), Color.Orange);
            Colorful.Console.Write(text + "\n", Color.White);
        }

        private static void CheckForUpdates(string fv)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Proxy = null;
                    var StatusAPI = webClient.DownloadString("http://juicyswapper.xyz/api/status");
                    Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

                    Input("Newest Version: " + StatusResponse.Version);
                    if (!StatusResponse.Version.Contains(fv))
                    {
                        Input("Update available! Please wait while we download it...");
                        Program.Download();
                    }
                    else
                    {
                        Input("You are up to date!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                }
                catch (Exception)
                {
                    Input("ERROR: SERVER_ERROR");
                }
            }
        }

        private static void GetFileVer()
        {
            if (File.Exists("Juicy Swapper v2.exe"))
            {
                FileVersionInfo fileVersionInfo = null;
                try
                {
                    fileVersionInfo = FileVersionInfo.GetVersionInfo("Juicy Swapper v2.exe");
                }
                catch (Exception e)
                {
                    Input("ERROR: " + e);
                }
                string text = string.Format("{0}.{1}.{2}.{3}", new object[]
                {
                    fileVersionInfo.FileMajorPart,
                    fileVersionInfo.FileMinorPart,
                    fileVersionInfo.FileBuildPart,
                    fileVersionInfo.FilePrivatePart,
                });
                Input("Current Version: " + text);
                Program.CheckForUpdates(text);
                return;
            }
            Program.Download();
        }

        private static void Download()
        {
            try
            {
                if (File.Exists("Juicy Swapper v2.exe"))
                {
                    File.Delete("Juicy Swapper v2.exe");
                }
                webclient.Proxy = null;
                webclient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webclient.DownloadFileAsync(new Uri("https://juicyswapper.xyz/download"), "Juicy Swapper v2.exe");
                while (webclient.IsBusy)
                    Thread.Sleep(1000);
                if (File.Exists("Juicy Swapper v2.exe"))
                {
                    Input("Finished! Launching Juicy Swapper v2...");
                    Process.Start("Juicy Swapper v2.exe");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Input("ERROR: File not downloaded!");
                }
            }
            catch (Exception arg)
            {
                Input("ERROR: " + arg);
                Console.Read();
            }
        }

        private static int counter;

        private static void ProgressChanged(object obj, DownloadProgressChangedEventArgs e)
        {
            counter++;

            if (counter % 200 == 0)
            {
                Input("Downloaded "
                                  + ((e.BytesReceived / 1024f) / 1024f).ToString("#0.##") + "MB"
                                  + " of "
                                  + ((e.TotalBytesToReceive / 1024f) / 1024f).ToString("#0.##") + "MB"
                                  + "  (" + e.ProgressPercentage + "%)"
                );
            }
        }

        private static void Completed(object obj, AsyncCompletedEventArgs e)
        {
        }
    }
}
