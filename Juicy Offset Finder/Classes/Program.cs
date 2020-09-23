using Juciy_OffsetFinder.Classes;
using Juciy_OffsetFinder.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading;

namespace Juciy_OffsetFinder
{
    class Program
    {
        private static string GetEpicDirectory() => Directory.Exists(@"C:\ProgramData\Epic") ? @"C:\ProgramData\Epic" : Directory.Exists(@"D:\ProgramData\Epic") ? @"D:\ProgramData\Epic" : Directory.Exists(@"E:\ProgramData\Epic") ? @"E:\ProgramData\Epic" : @"F:\ProgramData\Epic";
        private static bool DatFileExists() => File.Exists($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");
        static void Main(string[] args)
        {
            Console.WriteLine("Getting pak location...");
            Thread.Sleep(500);
            GetPaks();
        }

        static void GetOffsets()
        {
            //
            //CODES
            //
            string Body = "M_Med_Soldier_TV32";
            string Head = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Fuzzy_Bear_Donut/Materials/F_MED_FuzzyBear_Head.F_MED_FuzzyBear_Head";
            string PickMesh = "/Game/Weapons/FORT_Melee/Pickaxe_Default_MarkII";
            string PickSound = "/Game/Athena/Sounds/Weapons/PickAxes/";
            string BackMesh = "/Game/Accessories/FORT_Backpacks/Materials/Male_Ninja_03_V01";
            string Emote = "/Game/Animation/Game/MainPlayer/Emotes/Emote_Celebration_Female_M";
            string Lobby = "BID_001_BlueSquire.BID_001_BlueSquire";
            //
            //CP CODES
            //
            string CPBody = "/Game/Athena/Heroes/Meshes/Bodies/CP_Body_Commando_F_RebirthDefaultA.CP_Body_Commando_F_RebirthDefaultA";
            string CPHead = "/Game/Characters/CharacterParts/Female/Medium/Heads/CP_Head_F_RebirthDefaultA.CP_Head_F_RebirthDefaultA";
            string CPCPM = "CP_Athena_Body_M_RebirthSoldier";
            string CPCPf = "CP_Body_Commando_F_RebirthDefaultA";
            //
            //13+ CODES
            //
            string Body_13_ = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_Body.MI_F_MED_Renegade_Raider_Fire_Body";
            string Head_13_ = "/Game/Characters/Player/Female/Medium/Bodies/F_MED_Renegade_Raider_Fire/Materials/MI_F_MED_Renegade_Raider_Fire_Head.MI_F_MED_Renegade_Raider_Fire_Head";
            //
            //PAKS
            //
            string bodypath = pakPath + "\\pakchunk10_s8-WindowsClient.pak";
            string headpath = pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pickaxepath = pakPath + "\\pakchunk10-WindowsClient.pak";
            string pickaxesoundpath = pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string backblingpath = pakPath + "\\pakchunk10-WindowsClient.pak";
            string emotespath = pakPath + "\\pakchunk10-WindowsClient.pak";
            string idpath = pakPath + "\\pakchunk0-WindowsClient.pak";
            //
            //CP PAKS
            //
            string CP_Body = pakPath + "\\pakchunk10-WindowsClient.pak";
            string CP_Head = pakPath + "\\pakchunk10-WindowsClient.pak";
            string CPM = pakPath + "\\pakchunk10_s8-WindowsClient.pak";
            string CPF = pakPath + "\\pakchunk10-WindowsClient.pak";
            //
            //13+ PAKS
            //
            string Body_13 = pakPath + "\\pakchunk10_s19-WindowsClient.pak";
            string Head_13 = pakPath + "\\pakchunk10_s18-WindowsClient.pak";
            //
            //https://juicyswapper.xyz/api/offsets
            //
            Console.WriteLine(FindOffset(0, bodypath, Body) - 63113); //Body
            Console.WriteLine(FindOffset(0, headpath, Head) - 325994); //Head
            Console.WriteLine(FindOffset(0, pickaxepath, PickMesh) - 111373); //Pick_Mesh
            Console.WriteLine(FindOffset(0, pickaxesoundpath, PickSound) - 40947); //Pick_Sound
            Console.WriteLine(FindOffset(0, backblingpath, BackMesh) - 896506); //Back
            Console.WriteLine(FindOffset(0, emotespath, Emote) - 646842); //Emote
            Console.WriteLine(FindOffset(0, idpath, Lobby) - 2070798); //Lobby
            Console.WriteLine(FindOffset(0, Body_13, Body_13_) - 1372089); //body 13
            Console.WriteLine(FindOffset(0, Head_13, Head_13_) - 73470); //head 13
            Console.WriteLine("^ api/offsets ^");
            //
            //https://juicyswapper.xyz/api/cpoffsets
            //
            Console.WriteLine(FindOffset(0, CP_Body, CPBody)); //Cp body
            Console.WriteLine(FindOffset(0, CP_Head, CPHead)); //Cp head
            Console.WriteLine(FindOffset(0, CPM, CPCPM) + 891); //Cp cpm
            Console.WriteLine(FindOffset(0, CPF, CPCPf) + 964); //Cp cpf
            Console.WriteLine("^ api/cpoffsets ^");
            Console.WriteLine("Done!");
            Console.Read();
        }

        static void GetPaks()
        {
            if (DatFileExists())
            {
                string jsonData = File.ReadAllText($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");
                if (Utilities.IsValidJson(jsonData))
                {
                    JToken FortnitePath = JsonConvert.DeserializeObject<JToken>(jsonData);
                    if (FortnitePath != null)
                    {
                        JArray installationListArray = FortnitePath["InstallationList"].Value<JArray>();
                        if (installationListArray != null)
                        {
                            foreach (JToken FortnitePathReal in installationListArray)
                            {
                                if (string.Equals(FortnitePathReal["AppName"].Value<string>(), "Fortnite"))
                                {
                                    string path = $@"{FortnitePathReal["InstallLocation"].Value<string>()}\FortniteGame\Content\Paks";
                                    Properties.Settings.Default.pakPath = path;
                                    Properties.Settings.Default.Save();
                                    Console.Clear();
                                    Console.WriteLine("Searching offsets at: " + pakPath);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    GetOffsets();
                                }
                            }
                        }
                    }
                }
            }
        }

        public static string pakPath
        {
            get { return Properties.Settings.Default.pakPath; }
        }

        static long FindOffset(int Base, string Path, string Search)
        {        
            while (true)
            {
                if (Researcher.FindPosition(Base, Path, Search))
                {                    
                    return Settings.Default.current_offset;
                }
                else
                    Base += Base / 2 / 2;
            }
        }
    }
}
