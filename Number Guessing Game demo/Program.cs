namespace Number_Guessing_Game_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making a random object
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int gusses;
            String response;

            while(playAgain == true)
            {
                guess = 0;
                gusses = 0;
                response = "";
                //  The max number is exclusive so it need to be 101 if you want a number between 1 to 100.
                number = random.Next(min, max + 1);
                
                while(guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} - {max} :");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess {guess}");

                    if(guess > number)
                    {
                        Console.WriteLine($"{guess} is to high!");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine($"{guess} is to low!");
                    }
                    gusses++;
                }
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("You win!");
                Console.WriteLine($"Guesses: {gusses}");

                Console.WriteLine("Would you like to play again (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else 
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }
    }
}