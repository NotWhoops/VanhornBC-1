using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBC1.Services
{
    public class RPSServices
    {
        public string RPS()
        {

        string[] RPS = {
        "Rock",
        "Paper",
        "Scissors",
        "Lizard",
        "Spock"
        };

            Random rand = new Random();
            int index = rand.Next(RPS.Length);


            return $"RPS Program says: {RPS[index]}";
            
        }
    }
}