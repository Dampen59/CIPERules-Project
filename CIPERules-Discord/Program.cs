using System;
using Discord;
using Discord.Net;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Collections.Generic;
using AntiCaptcha.Api;
using AntiCaptcha.Helper;
using System.Linq;
using System.Net;

namespace CIPERulesDiscord
{
    class Program
    {
        private readonly DiscordSocketClient _client;
        private readonly IConfiguration _config;
        private WebClient wcSendToServer = new WebClient();
        private const string _CAPTCHA_API_KEY = "PUT_ANTI_CAPTCHA_API_KEY_HERE";
        private const string _CAPTCHA_REQUEST_PATTERN = "We have to check you are actually playing, tell us...";

        static void Main(string[] args)
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        public Program()
        {
            _client = new DiscordSocketClient();

            _client.Log += LogAsync;

            _client.Ready += ReadyAsync;

            _client.MessageReceived += MessageReceivedAsync;

            // Configuration..
            var _builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(path: "config.json");
            _config = _builder.Build();
        }

        public async Task MainAsync()
        {
            // Lecture du Token du fichier de Config
            await _client.LoginAsync(TokenType.Bot, _config["Token"]);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        private Task ReadyAsync()
        {
            Console.WriteLine($"Connected on the server as -> [{_client.CurrentUser}] :)");
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(SocketMessage message)
        {

            if (message.Author.Id == _client.CurrentUser.Id)
                return;

            // Check if the message is a captcha request
            if (message.Content.Contains(_CAPTCHA_REQUEST_PATTERN))
            {
                IReadOnlyCollection<Attachment> msgAttachments = message.Attachments;
                IReadOnlyCollection<SocketUser> msgMentionnedUser = message.MentionedUsers;

                // ID of the user that needs a captcha bypass
                ulong userId = msgMentionnedUser.ElementAt(0).Id;
                string userName = msgMentionnedUser.ElementAt(0).Username;

                // Sends bypass request to DB
                wcSendToServer.DownloadString($"http://127.0.0.1/needCaptcha.php?idDiscord={userId}");

                Console.WriteLine($"[Captcha] Captcha Request for User {userName} ({userId})");

                // Getting captcha image link
                string imgUrl = msgAttachments.ElementAt(0).Url;

                // Downloading captcha image
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(imgUrl), System.Environment.CurrentDirectory + $"/toBypass/{userId}.png");
                }

                // Captcha Bypass
                var api = new ImageToText
                {
                    ClientKey = _CAPTCHA_API_KEY,
                    FilePath = System.Environment.CurrentDirectory + $"/toBypass/{userId}.png"
                };

                if (!api.CreateTask())
                {
                    Console.WriteLine($"[Captcha] API send FAIL -> [{api.ErrorMessage}]");
                }
                else if (!api.WaitForResult())
                {
                    Console.WriteLine($"[Captcha] Couldn't solve captcha...");
                }
                else
                {
                    Console.WriteLine($"[Captcha] Captcha Solved for User {userName} ({userId}) -> [{api.GetTaskSolution().Text}]");

                    string captcha = api.GetTaskSolution().Text;
                    captcha = captcha.Replace("\"", "");

                    wcSendToServer.DownloadString($"http://127.0.0.1/insertCaptcha.php?idDiscord={userId}&captcha={captcha}");

                    await message.Channel.SendMessageAsync("Captcha Result : " + captcha);
                }

            }

        }
    }
}
