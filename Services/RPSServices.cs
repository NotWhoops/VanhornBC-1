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

            //ignore this just was testing stuff for the other project
            // if (choice == "Rock")
            // {
               
            // } 
            // if (choice == "Paper")
            // {
            //     return $"RPS Program says: {RPS[index]}";
            // }
            // if (choice == "Scissors")
            // {
            //     return $"RPS Program says: {RPS[index]}";
            // }
            // if (choice == "Lizard")
            // {
            //     return $"RPS Program says: {RPS[index]}";
            // }
            // if (choice == "Spock")
            // {
            //     return $"RPS Program says: {RPS[index]}";
            // }
            // else
            // {
            //     return "Thats not a choice. Please Enter Rock or Paper or Scissors or Lizard or Spock";
            // }
        }
    }
}