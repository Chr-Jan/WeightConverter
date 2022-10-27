namespace Arithmetic_Operators_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double friends = 5;
            //Or 5 + 1 = 6
            friends = friends + 1;
            Console.WriteLine(friends);

            //or we can use this, now the result is 8, since it was 6 before and now we add 2, so 6+2 = 8
            friends += 2;
            Console.WriteLine(friends);

            // We can add ++ to add 1 to the int number, so now it is 9
            friends++;
            Console.WriteLine(friends);

            //now we do the same just with substraction.
            friends = friends - 1;
            Console.WriteLine(friends);
            friends = friends -= 1;
            Console.WriteLine(friends);
            friends--;
            Console.WriteLine(friends);

            //and multiplying
            friends = friends * 2;
            Console.WriteLine(friends);
            friends = friends *= 2;
            Console.WriteLine(friends);
            
            //now divided
            friends = friends / 2;
            Console.WriteLine(friends);
            friends = friends /= 2;
            Console.WriteLine(friends);

            //The reminding operation, mutilus 
            double reminder = friends % 3;
            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}