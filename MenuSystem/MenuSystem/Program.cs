using System.Security.Cryptography.X509Certificates;

namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();

            mainMenu.Title = "Min fantastiske menu";

            // First menu item
            MenuItem mi = new MenuItem();
            mi.Title = "1. Gør dit";


            // Second menu item
            mi = new MenuItem();
            mi.Title = "2. Gør dat";
            mainMenu.menuItems[1] = mi;
            mainMenu.itemCount++;

            // Third menu item
            mi = new MenuItem();
            mi.Title = "3. Gør noget";
            mainMenu.menuItems[2] = mi;
            mainMenu.itemCount++;

            // Last menu item
            mi = new MenuItem();
            mi.Title = "4. Få svaret på livet, universet og alting";
            mainMenu.menuItems[3] = mi;
            mainMenu.itemCount++;

            mainMenu.Show();

            Console.ReadLine();
        }
    }
}
