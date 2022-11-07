using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_demo
{
    // Use an I before the name to indicate that it is a interface.
    public interface IMachine
    {
        bool Start();
        bool Stop();
    }

    public class Car : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Car started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Car stopped");
            return true;
        }
    }
    public class LawnMower : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Lawnmower started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Lawnmower stopped");
            return true;
        }
    }
}
