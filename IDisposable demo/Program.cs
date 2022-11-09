namespace IDisposable_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IDisposable =    call .close and .flush
            //                  release data and free unmanaged resources

            string[] lines = { "This is line1", "This is line2", "This is line3" };

            //using do not need dispose for freeing up resources and does not need .closing
            using (StreamWriter writer = new StreamWriter("test.txt"))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            StreamReader reader = new StreamReader("test.txt");

            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine("\nPress enter to exite");

            Console.ReadKey();
            //reader.Dispose() free up resouces used by reader
            //also include the function of .close and .flush
            reader.Dispose();
        }
    }
}