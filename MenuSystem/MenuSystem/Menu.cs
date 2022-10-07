using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    public class Menu
    {

        public string Title;
        private MenuItem[] menuItems;
        private int itemCount = 0;

        public string AddMenuItem(string menuTitle)
        {
            MenuItem temp = new MenuItem();
            menuItems[itemCount] = temp;
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(Title);
            Console.WriteLine();

            int menuindex = 0;
            while (menuindex < itemCount)
            {
                Console.WriteLine(menuItems[menuindex].Title);
                menuindex++;
            }
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunnkt eller 0 for at afslutte)");
        }
    }
}
