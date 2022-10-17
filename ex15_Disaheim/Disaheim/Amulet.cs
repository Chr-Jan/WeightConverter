using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string ItemId, Level Quality, string Design)
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
            this.Design = Design;
        }
        public Amulet(string ItemId):this(ItemId, Level.medium, "")
        {
        }
        public Amulet(string ItemId, Level Quality):this (ItemId, Quality, "")
        {
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}
