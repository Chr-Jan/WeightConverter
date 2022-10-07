using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Array_start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a_age;
            a_age = 21;
            int b_age;
            b_age = 22;
            int c_age;
            c_age = 23;
            int d_age;
            d_age = 26;
            int e_age;
            e_age = 28;
            int f_age;
            f_age = 35;
            /*          
            Console.WriteLine(a_age);
            Console.WriteLine(b_age);
            Console.WriteLine(c_age);
            Console.WriteLine(d_age);
            Console.WriteLine(e_age);
            Console.WriteLine(f_age);
            */
            int total;
            total = (a_age + b_age + c_age + d_age + e_age + f_age) / 6;
            /*
            Console.WriteLine("");

            Console.WriteLine(total + "\n");
            */
            //Array

            int[] arrayTest = {a_age, b_age, c_age, d_age, e_age, f_age};

            double average = 0;

            //gennemsnit alderen med et array
            //Console.WriteLine(arrayTest.Average() + "\n");

            average = average + arrayTest[0];
            average = average + arrayTest[1];
            average = average + arrayTest[2];
            average = average + arrayTest[3];
            average = average + arrayTest[4];
            average = average + arrayTest[5];
            /*
            Console.WriteLine(average / arrayTest.Length + "\n");
            */
            //eller
            //for (arrayTest.Lenght)
            /*
            for (int a = 0; a < 6; a++)
            {
                Console.WriteLine(arrayTest[a]);
            }
            */
            int[] arrayTest2 = new int[] { a_age, b_age, c_age, d_age, e_age, f_age };

            double average2 = 0;
            /*
            int checker;
            checker = int.Parse(Console.ReadLine());
            
            for (int a = 0; a < arrayTest2.Length; a++)
            {
                if (arrayTest2[a] == checker)
                {
                    Console.WriteLine("Congratulations " + arrayTest2[a]);
                }
                break;
            }
            */
            Console.WriteLine("Set size of array:");
           
            int userChoice = 0;
            int userAge;
            try
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error wrong answer");
            }

            int[] arrayTest3 = new int[userChoice];

            for (int a = 0; a < arrayTest3.Length; a++)
            {
                Console.WriteLine("Set user age:");
               
                try
                {
                    userAge = int.Parse(Console.ReadLine());
                    arrayTest3[a] = userAge;
                }
                catch { Console.WriteLine("Error wrong answer"); }
                
                
            }

            Console.WriteLine("Stored data:");

            for(int a = 0; a < arrayTest3.Length; a++)
            {
                Console.WriteLine(arrayTest3[a]);
            }

            Console.WriteLine("The End");  
            Console.ReadLine();


        }
    }
}