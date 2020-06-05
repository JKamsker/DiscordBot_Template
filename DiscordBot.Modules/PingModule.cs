using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class PingModule : ModuleBase
    {
        [Command("ping")]
        public async Task TestCommandAsync()
        {
            await ReplyAsync("Pong!");
        }

        [Command("awesome")]
        public async Task AwesomeCommand()
        {
            await ReplyAsync("Awesome!");
        }
    }
}