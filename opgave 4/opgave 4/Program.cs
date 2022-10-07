namespace opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String value = "hej hej hej hej hedder Kaj!";
            int startIndex = 23;
            int length = 4;
            String substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);

            Console.ReadLine();
        }
    }
}