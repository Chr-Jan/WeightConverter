using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_demo
{
    internal class Ex1
    {
        //for (statement 1; statement 2; statement 3) 
        //{
        //  // code block to be executed
        //}

        //Statement 1 is executed(one time) before the execution of the code block.
        //Statement 2 defines the condition for executing the code block.
        //Statement 3 is executed (every time) after the code block has been executed.
        
        public Ex1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
