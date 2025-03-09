using OrderCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalc.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Construcot_ShouldCreateProduct_WithValidParameters() 
        {
            //Arrange
            string name = "Apple";
            decimal price = 10.5m;
            int quantity = 3;

            //Act
            var product = new Product(name, price, quantity);

            //Assert
            Assert.Equal(name, product.Name);
            Assert.Equal(price, product.Price);
            Assert.Equal(quantity, product.Quantity);
        }

        [Fact]
        public void GetTotalPrice_WithPositivePriceAndQuantity_ReturnsCorrectTotal() 
        {
            //Arange
            string name = "Orange";
            decimal price = 12.5m;
            int quantity = 5;
            var product = new Product(name, price, quantity);

            //Act
            var result = product.GetTotalPrice();

            //Assert
            var expectedTotal = price * quantity;
            Assert.Equal(expectedTotal, result);
        }
    }
}
