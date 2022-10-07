using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthsday;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string MakeTitle()
        {
            return name + ";" + birthsday + ";" + height + ";" + isMarried + ";" + noOfChildren;
        }
        
        public Person(string name, DateTime birthsday, double height, bool isMarried, int noOfChildren)
        {
            this.name = name;
            this.birthsday = birthsday;
            this.height = height;
            this.isMarried = isMarried;
            this.noOfChildren = noOfChildren;
        }
    }
}
