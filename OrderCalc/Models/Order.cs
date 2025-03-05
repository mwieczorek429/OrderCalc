using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalc.Models
{
    public class Order : IOrder
    {
        private List<IProduct> _products = new();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (IProduct product in _products)
            {
                total += product.Price;
            }

            return total;
        }
    }
}
