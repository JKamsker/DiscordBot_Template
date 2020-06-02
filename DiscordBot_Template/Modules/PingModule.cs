using Discord.Commands;
using System.Threading.Tasks;

namespace CoderDojo_Discordbot.Modules
{
    public class PingModule : ModuleBase
    {
        [Command("ping")]
        public async Task TestCommandAsync()
        {
            await ReplyAsync("Pong!");
        }
    }
}