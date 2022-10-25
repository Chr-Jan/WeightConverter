using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    class UsefullTools
    {
        //We don't need to make a new instant with this class when it is static (example "Usefulltolls useullTools = new Usefulltools").
        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
