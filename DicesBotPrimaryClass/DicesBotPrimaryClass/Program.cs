using Discord.Commands;
using Discord;
using Discord.API;
using Discord.Audio;
using Discord.ETF;
using Discord.Legacy;
using Discord.Logging;
using Discord.Modules;
using Discord.Net;

class Program {
    static void Main(string[] args) => new Program().Start();

    private DiscordClient _client;

    public void Start() {
        _client = new DiscordClient();

        _client.MessageReceived += async (s, e) =>
        {
            if (!e.Message.IsAuthor)
                await e.Channel.SendMessage(e.Message.Text);
        };

        _client.ExecuteAndWait(async () => {
            await _client.Connect("A2DIIL47bpuwEA2_TQ6K2yGOewubZKQE", TokenType.Bot)
        });
    }
}
