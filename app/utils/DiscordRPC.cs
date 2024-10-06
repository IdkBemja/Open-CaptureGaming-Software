using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace Open_CaptureGaming_Software.app.utils
{
    public class DiscordRichPresence : IDisposable
    {
        private DiscordRpcClient client;

        public DiscordRichPresence(string clientId)
        {
            client = new DiscordRpcClient(clientId)
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine($"Conectado a Discord como {e.User.Username}");
            };
            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("RPC Presence Updated.");
            };
            client.Initialize();
        }

        public void SetPresence(string state, string largeImageText = null)
        {
            client.SetPresence(new RichPresence()
            {
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = "large_image",
                    LargeImageText = largeImageText
                }
            });
        }

        public void UpdatePresence(string state, string details)
        {
            var presence = client.CurrentPresence ?? new RichPresence();
            presence.State = state;
            presence.Details = details;
            client.SetPresence(presence);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
