using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalc.Models
{
    public class Product : IProduct
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public string Name 
        { get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("Name cannot be empty.", nameof(value));
                }

                _name = value;
            }
        }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return Price * Quantity;
        }
    }
}
