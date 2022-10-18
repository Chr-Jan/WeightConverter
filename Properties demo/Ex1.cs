using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Properties_demo
{
    internal class Ex1
    {
        private string _name = "John Doe";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
