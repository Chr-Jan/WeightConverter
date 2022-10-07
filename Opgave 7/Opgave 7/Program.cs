namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefgh";
            /*
                       char ch = str[1];

                       char ch2 = str[3];

                       char ch3 = str[5];

                       Console.WriteLine(ch + " " + ch2 + " " + ch3);
            */

            int index = 0;
            /*
            while (index < str.Length)
            {
                Console.WriteLine(str[index]);
                index++;
            }
            */
            do
            {
                //Console.WriteLine(str[index]);
                
                if(index%2==0)
                {
                    Console.WriteLine(str[index]);
                }
                index++;
            } while (str.Length > index);

            Console.ReadLine();


        }
    }
}