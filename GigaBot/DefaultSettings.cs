using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace GigaBot
{
    class DefaultSettings
    {
        public const string UserId = "XXXXX";
        public const string Password = "r1b0tfr2g";
        private DiscordClient client = new DiscordClient();

        private long DefaultChannelID = 133959873766359040;
        private long DefaultServerID = 131362574821359617;




        public Channel DefaultChannel(long ChannelID)
        {
            client.Run(async () =>
            {
                await client.Connect(UserId, Password);

                return client.GetChannel(DefaultChannelID);
                
            });

        }

    }
}
