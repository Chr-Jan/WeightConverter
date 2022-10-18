using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_vs_Out_demo
{
    // C# program to illustrate the
    // concept of out parameter
    using System;

    class OutDemo
    {
       
        public OutDemo()
        {

            // Declaring variable
            // without assigning value
            int G;

            // Pass variable G to the method
            // using out keyword
            Sum(out G);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
        }

        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }
    }

}
