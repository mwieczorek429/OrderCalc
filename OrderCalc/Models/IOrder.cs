using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalc.Models
{
    public interface IOrder
    {
        void AddProduct(IProduct product);
        decimal GetTotalPrice();
    }
}
