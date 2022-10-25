using Interfaces_and_Polymorphic_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_demo
{
    public class Airplane : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Airplane started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Airplane stopped");
            return true;
        }
    }
}
