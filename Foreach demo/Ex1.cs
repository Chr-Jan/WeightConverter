using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_demo
{
    public class Ex1
    {
        public Ex1()
        {
            List<int> list = new List<int>()
            { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200};

            foreach (int numbers in list)
            {
                Console.WriteLine(numbers);
            }
        }

}
}
