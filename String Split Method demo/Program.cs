namespace String_Split_Method_demo
{
    using System;

    class Program
    {
        static void Main()
        {
            // Contains a semicolon delimiter.
            string input = "cat;bird";
            Console.WriteLine($"Input: {input}");

            // Part 1: split on a single character.
            string[] array = input.Split(';');

            // Part 2: use a foreach-loop.
            // ... Print each value in the array.
            foreach (string value in array)
            {
                Console.WriteLine($"Part: {value}");
            }
        }
    }
}
    