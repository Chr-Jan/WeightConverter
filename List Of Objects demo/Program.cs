using System.Security.Cryptography.X509Certificates;

namespace List_Of_Objects_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<datatype> name of list = new list <datatype>();
            List<Player> players = new List<Player>();
            List<Player> players2 = new List<Player>();

            //instance player objects
            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            //name of the list.Add(object name)
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            //foreach(dataype, object in list name
            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }

            //foreach(dataype, object in list name
            //work without .username because of override in ex1
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            //alternative
            players2.Add(new Player("Chad"));
            players2.Add(new Player("Steve"));
            players2.Add(new Player("Karen"));

            foreach (Player player in players2)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
}