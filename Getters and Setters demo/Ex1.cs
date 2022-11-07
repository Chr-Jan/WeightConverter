using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters_demo
{
    internal class Car
    {
        //field
        private int speed;

        public Car(int speed)
        {
            this.speed = speed;
        }
        //property
        public int Speed
        {
            get { return speed; } //read 
            set //writeable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
