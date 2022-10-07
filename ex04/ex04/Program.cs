using System;
using System.Runtime.CompilerServices;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opgave 5.1
            Console.WriteLine("Min fantastiske menu:\n");
            Console.WriteLine("Hvis ’1’, skriv Punkt 1 er valgt: Gør dit");
            Console.WriteLine("Hvis ’2’, skriv Punkt 2 er valgt: Gør dat");
            Console.WriteLine("Hvis ’3’, skriv Punkt 3 er valgt: Gør noget");
            Console.WriteLine("Hvis ’4’, skriv Punkt 4 er valgt: 42");
            //Console.WriteLine("skriv ”Forkert valg”");

            int menu = int.Parse(Console.ReadLine());
            string message = "";

            Console.Clear();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Gør dit");
                    //message = "Gør dit";
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Gør dat");
                    Console.ReadLine();
                    //message = "Gør dat";
                    break;

                case 3:
                    Console.WriteLine("Gør noget");
                    Console.ReadLine();
                    //message = "Gør noget";
                    break;

                case 4:
                    Console.WriteLine("42");
                    Console.ReadLine();
                    //message = "42";
                    break;

                default:
                    Console.WriteLine("Forkert svar");
                    Console.ReadLine();
                    //message = "Forkert svar";
                    break;
            }

            //Exercise 2.4
            // spot 3 is d, because a equal to spot 0
            Console.Clear();
            string test = "abcdefg";
            char ch = test[3];
            Console.WriteLine(ch);
            Console.ReadLine();
            Console.Clear();

            //Exercise 2.5
            string words = "hello my name is slim shady";
            int words2 = words.Length;
            int count;
            int count2;
            count = 0;
            count2 = 0;

            while (count < words2)
            {
                Console.WriteLine(words[count]);
                count++;
            }

            //Exercise 2.6
            do
            {
                Console.WriteLine(words[count2]);
                count2++;
            }
            while (count2 < words2);

            Console.ReadLine();
            Console.Clear();

            //Exercise 2.7
            int a = 4;
            int b = 5;

            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine();
            Console.Clear();

            //Exercise 2.8

            bool quitter = true;

            do
            {
                Console.WriteLine("Min fantastiske menu:\n");
                Console.WriteLine("Hvis ’1’, skriv Punkt 1 er valgt: Gør dit");
                Console.WriteLine("Hvis ’2’, skriv Punkt 2 er valgt: Gør dat");
                Console.WriteLine("Hvis ’3’, skriv Punkt 3 er valgt: Gør noget");
                Console.WriteLine("Hvis ’4’, skriv Punkt 4 er valgt: 42");
                Console.WriteLine("Hvis ’5’, hvis du ønsker at afslutte");

                int menu2 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menu2)
                {
                    case 1:
                        Console.WriteLine("Gør dit");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Gør dat");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Gør noget");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("42");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Du må have en god dag.");
                        quitter = false;
                        break;

                    default:
                        Console.WriteLine("Forkert svar");
                        Console.ReadLine();
                        break;
                }

            } while (quitter == true);
            Console.Clear();
            //Exercise 2.9
            //Ikke færdig
            string words3 = "hello my name is slim shady";
            int ex_words = words3.Length;
            int count3 = 0;


            while (count3 < ex_words)
            {
                Console.Write(words3[count3]);
                count3 += 2;
            }

            Console.ReadLine();
            Console.Clear();

            //Exercise 2.10

            string words4 = "l7ja2p3j2";
            int ex_words2 = words4.Length;
            int count4 = 0;

            while (count4 < ex_words2)
            {
                //If one of the cases 'numbers' are equal to the array (words4) index (count4) number the switch is correct.
                switch (words4[count4])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        //count4+1 is to avoid 0 index in output text and use normal people speak.
                        Console.WriteLine(count4 + 1 + ": " + words4[count4]);
                        break;

                }

                count4++;
            }
            Console.Clear();

            //Exercise 2.11

            string words5 = "l7j-a3j+2";
            int ex_words3 = words5.Length;
            int count5 = 0;

            while (count5 < ex_words3)
            {
                switch (words5[count5])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':

                    //count4+1 is to avoid 0 index in output text and use normal people speak.
                        Console.WriteLine(count5 + 1 + ": " + words5[count5] + "(ciffer)");
                        break;
                    //the same expressoin statement, but - and + is added below since there should be different text after the different types (ciffer/op
                    case '-':
                    case '+':
                        Console.WriteLine(count5 + 1 + ": " + words5[count5] + "(operator)");
                        break;
                    default:
                        Console.WriteLine(count5 + 1 + ": " + words5[count5] + "(ukendt)");
                        break;
                }

                count5++;
            }

            Console.ReadLine();
            Console.Clear();

            //Exercise 2.12

            Console.WriteLine("Please input with only one number equation:");
            string words6 = Console.ReadLine();
            int ex_words4 = words6.Length;
            int count6 = 0;
            
            int result = 0;
            int number = 0;
            char symbol = '+';

            while (count6 < ex_words4)
            {
                switch (words6[count6])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        number = words6[count6]-48;
                        break;
                    case '-':
                    case '+':
                        symbol = words6[count6];
                        break;
                    default:
                        break;
                }
                if (symbol == '+')
                {
                    result = result + number;
                    number = 0;
                }
                else if (symbol == '-')
                {
                    result = result - number;
                    number = 0;
                }

                count6++;
            }

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}