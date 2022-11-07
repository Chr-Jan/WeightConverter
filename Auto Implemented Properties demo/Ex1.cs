using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented_Properties_demo
{
    internal class Car
    {

        //field
        private string model;

        ////porperty
        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        //alternative, using the Auto-Implemented property:
        public string Model 
        { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }
    }
}
