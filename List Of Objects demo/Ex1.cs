using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_Objects_demo
{
    public class Player
    {
        //field
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
