namespace Generics_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic =    "not specific to a particular data type"
            //              add <T> to: classes, methods, fields, etc.
            //              allows for code reusability for different data types

            //arrays
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
        //generic method
        //does the same as the method below
        public static void displayElements<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        ////method
        //public static void displayElements(int[] array)
        //{
        //    foreach (int element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //    Console.WriteLine();
        //}
        ////method
        //public static void displayElements(double[] array)
        //{
        //    foreach (double element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //    Console.WriteLine();
        //}
        ////method
        //public static void displayElements(string[] array)
        //{
        //    foreach (string element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}
    }
}