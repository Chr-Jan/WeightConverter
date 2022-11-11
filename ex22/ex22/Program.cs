namespace ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader sr = new StreamReader("test.txt");
            //try
            //{

            //        string line;
            //        // Read and display lines from the file until the end of
            //        // the file is reached.
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
                
            //}
            //finally
            //{
            //    sr.Close();
            //}
            string fileName = "test.txt";

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadLine();
        }
    }
}