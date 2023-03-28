﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_IArticle
{
    internal class Smartphone: IArticle
    {
        public double Price { get; set; }
        public string Description { get; set; }

        public Smartphone(double price, string description)
        {
            Price = price;
            Description = description;
        }
    }
}
