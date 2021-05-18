using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Rock_Paper_Scissors
{
    class RPSApp
    {
        public static bool PlayAgain { get; set; }
        public static int Con { get; set; }
        public static Player Opp { get; set; }
        public static int Wins { get; set; }
        public static int Losses { get; set; }


        public static void play()
        {
            //create player and gets their name
            var user = new HumanPlayer();

            // Game setup
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Would you like to play against a RockPlayer or a RandomPlayer? (rock/rand)");
                var answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "rockplayer":
                    case "rock":
                        Opp = new RockPlayer();
                        Opp.Name = "RockPlayer";
                        repeat = false;
                        break;
                    case "randomplayer":
                    case "rand":
                        Opp = new RandomPlayer();
                        Opp.Name = "RandomPlayer";
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid, only enter either rock or rand");
                        repeat = true;
                        break;
                }
            }


            //Gameplay
            bool PlayAgain = true;
            while (PlayAgain)
            {
                user.Pick();

                var userResult = user.GenerateRPS();

                var OppResult = Opp.GenerateRPS();

                switch (userResult)
                {
                    case RPS.rock:
                        switch (OppResult)
                        {
                            case RPS.rock:
                                Console.WriteLine($"{user.Name}: rock");
                                Console.WriteLine($"{Opp.Name}: rock");
                                Console.WriteLine("It's a draw");
                                break;

                            case RPS.paper:
                                Console.WriteLine($"{user.Name}: rock");
                                Console.WriteLine($"{Opp.Name}: paper");
                                Console.WriteLine($"{Opp.Name} wins!");
                                Losses++;
                                break;

                            case RPS.scissors:
                                Console.WriteLine($"{user.Name}: rock");
                                Console.WriteLine($"{Opp.Name}: scissors");
                                Console.WriteLine($"{user.Name} wins!");
                                Wins++;
                                break;
                        }
                        Console.WriteLine($"{Wins} wins, {Losses} losses");
                        break;

                    case RPS.paper:
                        switch (OppResult)
                        {
                            case RPS.rock:
                                Console.WriteLine($"{user.Name}: paper");
                                Console.WriteLine($"{Opp.Name}: rock");
                                Console.WriteLine($"{user.Name} wins!");
                                Wins++;
                                break;

                            case RPS.paper:
                                Console.WriteLine($"{user.Name}: paper");
                                Console.WriteLine($"{Opp.Name}: paper");
                                Console.WriteLine($"It's a draw!");
                                break;

                            case RPS.scissors:
                                Console.WriteLine($"{user.Name}: paper");
                                Console.WriteLine($"{Opp.Name}: scissors");
                                Console.WriteLine($"{Opp.Name} wins!");
                                Losses++;
                                break;
                        }
                        Console.WriteLine($"{Wins} wins, {Losses} losses");
                        break;

                    case RPS.scissors:
                        switch (OppResult)
                        {
                            case RPS.rock:
                                Console.WriteLine($"{user.Name}: scissors");
                                Console.WriteLine($"{Opp.Name}: rock");
                                Console.WriteLine($"{Opp.Name} wins!");
                                Losses++;
                                break;

                            case RPS.paper:
                                Console.WriteLine($"{user.Name}: scissors");
                                Console.WriteLine($"{Opp.Name}: paper");
                                Console.WriteLine($"{user.Name} wins!");
                                Wins++;
                                break;

                            case RPS.scissors:
                                Console.WriteLine($"{user.Name}: scissors");
                                Console.WriteLine($"{Opp.Name}: scissors");
                                Console.WriteLine($"It's a draw!");
                                break;
                        }
                        Console.WriteLine($"{Wins} wins, {Losses} losses");
                        break;
                }

                var rResult = Repeater();
                if (rResult == 1)
                    PlayAgain = true;
                else
                    PlayAgain = false;
            }


        }



        //Play again?
        public static int Repeater()
        {
            bool conLoop = true;
            while (conLoop)
            {
                Console.WriteLine("Play again? (y/n)");
                string vCon = Console.ReadLine().ToLower();

                switch (vCon)
                {
                    case "y":
                        conLoop = false;
                        Con = 1;
                        break;

                    case "n":
                        Console.WriteLine("Goodbye!");
                        conLoop = false;
                        Con = 0;
                        break;

                    default:
                        Console.WriteLine("I didn't catch that");
                        conLoop = true;
                        Con = 1;
                        break;
                }

            }
            return Con;
        }
    }

}
