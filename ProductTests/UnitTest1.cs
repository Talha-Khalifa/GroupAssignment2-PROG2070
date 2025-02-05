using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductTests
{
  [TestFixture]
    public class ProductTests
    {
        // Test for ItemPrice - Valid Price
        [Test]
        public void ItemPrice_SetValidPrice_ShouldStoreCorrectValue()
        {
            
            var product = new Product(1001, "Laptop", 1000.00m, 10);
            
            
            product.ItemPrice = 1500.00m;
            
            
            Assert.That(product.ItemPrice, Is.EqualTo(1500.00m));
        }

        // Test for ItemPrice - Minimum Boundary
        [Test]
        public void ItemPrice_SetMinimumPrice_ShouldStoreCorrectValue()
        {
            
            var product = new Product(1002, "Mouse", 10.00m, 50);
            i
            
            product.ItemPrice = 5.00m;
            
            
            Assert.That(product.ItemPrice, Is.EqualTo(5.00m));
        }

        // Test for ItemPrice - Maximum Boundary
        [Test]
        public void ItemPrice_SetMaximumPrice_ShouldStoreCorrectValue()
        {
            
            var product = new Product(1003, "Monitor", 500.00m, 20);
            
            
            product.ItemPrice = 5000.00m;
            
            
            Assert.That(product.ItemPrice, Is.EqualTo(5000.00m));
        }

        // Test for StockAmount - Valid Stock Update
        [Test]
        public void StockAmount_SetValidStock_ShouldStoreCorrectValue()
        {
            
            var product = new Product(2001, "Keyboard", 80.00m, 30);
            
            
            product.StockAmount = 100;
            
           
            Assert.That(product.StockAmount, Is.EqualTo(100));
        }

        // Test for StockAmount - Minimum Boundary
        [Test]
        public void StockAmount_SetMinimumStock_ShouldStoreCorrectValue()
        {
            
            var product = new Product(2002, "Headphones", 200.00m, 40);
            
           
            product.StockAmount = 5;
            
            
            Assert.That(product.StockAmount, Is.EqualTo(5));
        }

        // Test for StockAmount - Maximum Boundary
        [Test]
        public void StockAmount_SetMaximumStock_ShouldStoreCorrectValue()
        {
            
            var product = new Product(2003, "Speakers", 300.00m, 50);
            
            
            product.StockAmount = 500000;
            
            
            Assert.That(product.StockAmount, Is.EqualTo(500000));
        }
    }
}
