namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            while (stop)
            {
                Console.Clear();
                Console.WriteLine("indtast første heltal:");

                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("indtast anden heltal: ");

                int b = int.Parse(Console.ReadLine());

                int resultat = a / b;

                Console.WriteLine(resultat);

                float resultat2 = a % b;

                Console.WriteLine(resultat2);

                Console.WriteLine("ønsker du at stoppe? Skrive ja:");

                string writeStop = Console.ReadLine();

                if ("ja" == writeStop)
                {
                    stop = false;
                }
            }
        }
    }
}