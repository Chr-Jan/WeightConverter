using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }


        public Course(string Name, int DurationInMinutes)
        {
            this.Name = Name;
            this.DurationInMinutes = DurationInMinutes;
        }
        public Course(string Name) : this(Name, 0)
        {
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

    }
}
