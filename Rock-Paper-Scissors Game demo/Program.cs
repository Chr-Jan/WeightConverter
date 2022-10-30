using System.Diagnostics;

namespace Rock_Paper_Scissors_Game_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random object
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            //You can also just write while(playAgain) since it is set above to true.
            while (playAgain == true)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }
                //Will generate a number between 1 and 3
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                switch(player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if(computer == "SCISSORS")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}