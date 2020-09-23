using DiscordRPC;
using System.Windows.Forms;

namespace JuicyLauncher
{
    public class Juicy
	{
        public static readonly DiscordRpcClient discordrpc = new DiscordRpcClient("704324460291031047");
        public static void SetDiscordLocation(string Location)
        {
            discordrpc.SetPresence(new RichPresence
            {
                Details = $"🧃 • {Location}",
                State = "🧃 • juicyswapper.xyz",
				Assets = new Assets { LargeImageKey = "discordsmall2", LargeImageText = $"🧃 • Version v{Application.ProductVersion}"}
            });
        }
	}
}
