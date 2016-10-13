using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using Discord.API;
using Discord.Audio;
using Discord.ETF;
using Discord.Legacy;
using Discord.Logging;
using Discord.Modules;
using Discord.Net;

namespace DicesBotPrimaryClass
{
    class StefanoClass
    {
        private int randomNumber = 0;
        public string theNumber;
        

        public int ToCall(int dado, int nDadi)
        {
            for(int i = 0; i < nDadi; i++)
            {
                randomNumber = Random(dado);
                theNumber = Convert.ToString(randomNumber);
                Console.WriteLine(theNumber);
            }
        }

        public int Random(int dado)
        {
            Random value = new Random();
            int rndValue = value.Next(1, dado + 1);
        }

    }
}
