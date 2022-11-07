using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Static_demo
{
    public class Car
    {
        String model;
        public static int numberOfCars;
        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
        //static method
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
