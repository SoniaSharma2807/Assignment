﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class CartItem
    {
        public Product Product
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }
    }
}
