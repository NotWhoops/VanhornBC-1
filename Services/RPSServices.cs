using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBC1.Services
{
    public class RPSServices
    {
        public string RPS(string option)
        {

        string[] RPS ={
        "Rock",
        "Paper",
        "Scissors",
        "Lizard",
        "Spock"
        };

            Random rand = new Random();
            int index = rand.Next(RPS.Length);


            if (option != "Rock Paper Scissors Lizard Spock")
            {
                return "Thats not a option. Please Enter Rock or Paper or Scissors or Lizard or Spock";
            }
            else
            {   
                return $"RPS Program says: {RPS[index]}";
            }
        }
    }
}