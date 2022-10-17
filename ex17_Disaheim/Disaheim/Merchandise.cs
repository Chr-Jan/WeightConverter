using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {

        public string ItemId { get; set; }


        //public Merchandise(string ItemId)
        //{
        //    this.ItemId = ItemId;
        //}

        public override string ToString()
        {
            return "ItemId: " + ItemId;
        }
    }
}
