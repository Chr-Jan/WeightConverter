using System;

namespace Properties_demo
{
    internal class Program
    {
        //property =    A property is a member that provides a flexible mechanism to read, 
        //              write, or compute the value of a private field. 

        static void Main(string[] args)
        {
            Console.WriteLine("This is exampel 1:");
            Ex1 ex1 = new Ex1();
            Console.WriteLine(ex1.Name);

        }
    }
}