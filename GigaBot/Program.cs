using Discord;
using Discord.Audio;
using Discord.Commands;
using Discord.Commands.Permissions.Levels;
using Discord.Commands.Permissions.Userlist;
using Discord.Modules;
using System;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace GigaBot
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var client = new DiscordClient();
            var _login = new Login();

            using (var browser = new IE("http://inara.cz/wing-roster/242"))
            {

            }




                client.Run(async () =>
                {
                    await client.Connect(_login.UserId, _login.Password);
                    Console.WriteLine("Logged In.");

                    Console.WriteLine(client.GetServer(131362574821359617));
                    Console.WriteLine(client.GetChannel(133959873766359040));
                    await client.SendMessage(client.GetChannel(133959873766359040), "Hello World!");

                });
        }
    }
}

