﻿using System.IO;


namespace Read_from_and_Write_to_a_text_file_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading code are below

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("D:\\GitLab\\Sample.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            //Writing code is below

            //try
            //{
            //    //Pass the filepath and filename to the StreamWriter Constructor
            //    StreamWriter sw = new StreamWriter("D:\\GitLab\\Sample.txt");
            //    //Write a line of text
            //    sw.WriteLine("Hello World!!");
            //    //Write a second line of text
            //    sw.WriteLine("From the StreamWriter class");
            //    //Close the file
            //    sw.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}

        }
    }
}