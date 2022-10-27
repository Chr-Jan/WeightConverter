namespace While_Loops_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            Console.Write("Enter your name: ");
            String name = "";

            // while will loop if the condition is true, here it loop if the user just press enter
            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }



            //exampel of a infinite loop
            while(1==1)
            {
                Console.WriteLine("HELP! I'm STUCK in a infinaite loop");
            }

            Console.WriteLine($"Hello {name}");

            Console.ReadKey();
        }
    }
}