using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Services
{
    public class RockPaperServices
    {
        public string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
        public string[] respownse = { "Boo!", "You Fail!", "Nice Try"};
        public string[] Winner = { "You Win!", "Victory!", "Cha-Ching" };
        Random random = new();
        public string RandomCPUChoice(){
            return choices[random.Next(choices.Length)];
        }
        
        public string GamePlay(string Input)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                if (Input.ToLower() == choices[i])
                {
                    break;
                }
                if (i == choices.Length - 1)
                {
                    return "Please Enter rock,paper,scissors,lizard,or spock";
                }

            }
            string CPUChoice = choices[random.Next(choices.Length)];
            string lostRespownses = respownse[random.Next(respownse.Length)];
            string winnerRespownses = Winner[random.Next(Winner.Length)];
            if (Input.ToLower() == CPUChoice)
            {
                return "Its A Draw";
            }
            switch (Input)
            {
                case "rock":
                    switch (CPUChoice)
                    {
                        case "scissors":
                        case "lizard":
                            return $"{winnerRespownses}, you choose {Input} the CPU {CPUChoice}";
                        default:
                            return $"{lostRespownses}, you choose {Input} the CPU {CPUChoice}";
                    }
                case "paper":
                    switch (CPUChoice)
                    {
                        case "rock":
                        case "spock":
                            return $"{winnerRespownses}, you choose {Input} the CPU {CPUChoice}";
                        default:
                            return $"{lostRespownses}, you choose {Input} the CPU {CPUChoice}";
                    }
                case "scissors":
                    switch (CPUChoice)
                    {
                        case "paper":
                        case "lizard":
                            return $"{winnerRespownses}, you choose {Input} the CPU {CPUChoice}";
                        default:
                            return $"{lostRespownses}, you choose {Input} the CPU {CPUChoice}";
                    }
                case "lizard":
                    switch (CPUChoice)
                    {
                        case "spock":
                        case "paper":
                            return $"{winnerRespownses}, you choose {Input} the CPU {CPUChoice}";
                        default:
                            return $"{lostRespownses}, you choose {Input} the CPU {CPUChoice}";
                    }
                case "spock":
                    switch (CPUChoice)
                    {
                        case "scissors":
                        case "rock":
                            return $"{winnerRespownses}, you choose {Input} the CPU {CPUChoice}";
                        default:
                            return $"{lostRespownses}, you choose {Input} the CPU {CPUChoice}";
                    }
            }
            return "Please Enter rock,paper,scissors,lizard,or spock";
        }


    }
}