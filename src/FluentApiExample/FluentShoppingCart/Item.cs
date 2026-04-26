using System;
using System.Collections.Generic;
using System.Text;

namespace FluentShoppingCart
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        internal Item()
        {
        }
    }
}
