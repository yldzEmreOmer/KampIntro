﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to the basket: " + product.Name);
        }
    }
}
