using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GC_Lab_Rock_Paper_Scissors
{
    class HumanPlayer : Player
    {
        //Properties
        public string Name { get; set; }
        public static  RPS Answer { get; set; }

        //Constructor
        public HumanPlayer()
        {
            PromptName();
        }

        public void PromptName()
        {
            Console.WriteLine("What's your name?");

            var name = Console.ReadLine();

            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please only use letters in your name! Try again!");
                name = Console.ReadLine();
            }

            this.Name = name;

        }


        //Gameplay
        public void Pick()
        {
            bool failSafe = true;
            while (failSafe)
            {
                Console.WriteLine("Rock, paper, or scissors? (R/P/S)");
                var pick = Console.ReadLine().ToLower();

                switch (pick)
                {
                    case "rock":
                    case "r":
                        Answer = RPS.rock;
                        failSafe = false;
                        break;

                    case "paper":
                    case "p":
                        Answer = RPS.paper;
                        failSafe = false;
                        break;

                    case "scissors":
                    case "s":
                        Answer = RPS.scissors;
                        failSafe = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        failSafe = true;
                        break;
                }
            }
        }
        public RPS GenerateRPS()
        {
                return Answer;
        }
    }
}