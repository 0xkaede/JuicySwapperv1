using JuicySwapper.Main;
using DiscordRPC;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using JuicySwapper.Main.GUI;

namespace JuicySwapper
{
    public class Juicy
	{
        public static readonly DiscordRpcClient discordrpc = new DiscordRpcClient("704324460291031047");
        public static void SetDiscordLocation(string Location)
        {
            discordrpc.SetPresence(new RichPresence
            {
                Details = $"🧃 • In {Location} Tab",
                State = "🧃 • juicyswapper.xyz",
				Assets = new Assets { LargeImageKey = "discordsmall2", LargeImageText = $"🧃 • Version v{Application.ProductVersion}"}
            });
        }

		public static void SetDiscordAction(string Action)
		{
			discordrpc.SetPresence(new RichPresence
			{
				Details = $"🧃 • {Action}",
				State = "🧃 • juicyswapper.xyz",
				Assets = new Assets { LargeImageKey = "discordsmall2", LargeImageText = $"🧃 • Version v{Application.ProductVersion}"}
			});
		}

		private static string Decrypt(string cipherText)
		{
			cipherText = cipherText.Replace(" ", "+");
			byte[] cipherBytes = Convert.FromBase64String(cipherText);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes("datexd", new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				encryptor.Padding = PaddingMode.PKCS7;
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(cipherBytes, 0, cipherBytes.Length);
					}
					cipherText = Encoding.Unicode.GetString(ms.ToArray());
				}
			}
			return cipherText;
		}

		public static void DevModeCheck()
		{
			//Security Check...
			if (Devmode() == false)
			{
				//Devmode check
				if (!Juicy.Devmode())
				{
					new DevMode().ShowDialog();
				}				
			}
			else
			{
			}
		}

		public static bool Devmode()
		{
			using (var client = new WebClient())
			{
				client.Proxy = null;
				var encr = client.DownloadString("https://juicyswapper.xyz/api/devmode");
				if (Decrypt(encr) == "false")
					return true;
				else
					return false;
			}
		}
	}
}
