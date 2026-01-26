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


            
            if (option == "Rock")
            {
                return $"RPS Program says: {RPS[index]}";
            } 
            if (option == "Paper")
            {
                return $"RPS Program says: {RPS[index]}";
            }
            if (option == "Scissors")
            {
                return $"RPS Program says: {RPS[index]}";
            }
            if (option == "Lizard")
            {
                return $"RPS Program says: {RPS[index]}";
            }
            if (option == "Spock")
            {
                return $"RPS Program says: {RPS[index]}";
            }
            else
            {
                return "Thats not a option. Please Enter Rock or Paper or Scissors or Lizard or Spock";
            }
        }
    }
}