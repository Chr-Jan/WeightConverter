namespace Iterations_and_Reading_Data_from_a_Text_File_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using to open the value.txt file
            StreamReader myReader = new StreamReader("Values.txt");
            //declare a empy string called line
            string line = "";

            //is running while line is not set to null. 
            //an empy line is not an unknown and therefore does not end the while loop.
            //will close the while loop when the end of the value.txt file is ended.
            while (line != null)
            {
                line = myReader.ReadLine();
                if(line != null)
                    Console.WriteLine(line);
            }
            //important to close the file and streamreader.
            myReader.Close();
            Console.ReadLine();
        }
    }
}