﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalc.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }

        decimal GetTotalPrice();

    }
}
