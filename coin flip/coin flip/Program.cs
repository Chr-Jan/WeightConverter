using System;
using System.Reflection.Metadata.Ecma335;

namespace coin_flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char u_action = 'Y';


            while (u_action == 'y')
            {
                Random coin = new Random();
                int flip = coin.Next(0, 2);
                Console.WriteLine((flip == 0) ? "heads\n" : "tails\n");

                Console.WriteLine("Do you want to continue!\n");
                Console.WriteLine("Press Y to continue");
                Console.WriteLine("Press N to finish");
                u_action = Console.ReadKey().KeyChar;
                Console.Clear();

            }
            Console.ReadLine();
        }
    }
}