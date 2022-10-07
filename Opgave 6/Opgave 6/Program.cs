using System.Diagnostics;

namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fantasiske menu:\n");

            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet, universet og alting!\n");
            Console.WriteLine("Tryk menu 1, 2, 3 eller 4");

            //Switch

            int valg;

            valg = int.Parse(Console.ReadLine());

            switch(valg)
            {
                case 1: 
                    Console.WriteLine("Gør dit");
                break;
                
                case 2:
                    Console.WriteLine("Gør dat");
                break;

                case 3:
                    Console.WriteLine("Gør noget");
                    break;

                case 4:
                    Console.WriteLine("Tilykke jeg gider ikke at skrive den lange sætning igen");
                    break;

            }

            Console.ReadLine();
        }
    }
}