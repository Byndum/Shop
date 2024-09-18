﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class Item
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item(string id, string description, double price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
