namespace Foreach_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200};

            foreach (int numbers in list)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}