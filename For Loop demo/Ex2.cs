using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_demo
{
    class Ex2
    {
        public Ex2()
        {
            const string value = "abc";
       
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }
        }
    }
}
