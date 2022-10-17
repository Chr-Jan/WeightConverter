using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace Disaheim
{
    public class Utility
    {

        public double GetValueOfBook(Book book)
        {
            double b_output;
            b_output = book.Price;
            return b_output;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double a_output = 0;

            if (amulet.Quality == Level.low)
                a_output = 12.5;
            else if (amulet.Quality == Level.medium)
            {
                a_output = 20.0;
            }
            else if (amulet.Quality == Level.high)
            {
                a_output = 27.5;
            }
            return a_output;
        }

        public double GetValueOfCourse(Course course)
        {
            int hours = course.DurationInMinutes/60;
            double price = 875;
            double Remaninders = course.DurationInMinutes%60;
            double total_price = 0;

            if (Remaninders > 1)
            {
                hours++;
                total_price = hours * price;
            }
            else
            {
                total_price = hours * price;
            }

            return total_price;
        }
    }
}
