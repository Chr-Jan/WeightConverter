using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_vs_Out_demo
{
    // C# program to illustrate the
    // concept of ref parameter
    using System;

    class RefDemo
    {

        // Main Method
        public RefDemo()
        {

            // Assign string value
            string str = "Geek";

            // Pass as a reference parameter
            SetValue(ref str);

            // Display the given string
            Console.WriteLine(str);
        }

        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            str1 = "GeeksforGeeks";
        }
    }
}
