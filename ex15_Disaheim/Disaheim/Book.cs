﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string ItemId, string Title, double Price)
        {
            this.ItemId = ItemId;
            this.Title = Title;
            this.Price = Price;
        }
        public Book(string ItemId, string Title):this(ItemId, Title, 0.0)
        {
        }
        public Book(string ItemId):this (ItemId, "", 0.0)
        {
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
