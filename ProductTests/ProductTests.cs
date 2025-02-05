using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductTests
{
    [TestClass]
    public class ProductTests
    {
        // These unit tests are created to check how well the 'Product' class works, especially focusing on the 'ProdId' and 
        // 'ProdName' properties. We want to make sure these properties are set correctly, return the right values, and follow 
        // the rules we have, like making sure product names aren’t too long or too short.

        // Here’s why I chose these tests:
        // 1. First, I’m testing that the ProdId is set correctly, so it holds and returns the right value.
        // 2. Then, I’m checking the edge cases for ProdId, making sure the system works with both the lowest and highest possible values.
        // 3. Finally, I’m testing ProdName to make sure it’s set right, not left blank, and the length is reasonable.

        // Written by Talha: These tests are important to make sure the Product class works correctly for different inputs and
        // follows the business rules for handling product information.

        [TestMethod]
        public void TestValidProdId()
        {
            // Arrange
            var product = new Product(12345, "Product A", 100, 50);

            // Act
            var result = product.ProdId;

            // Assert
            Assert.AreEqual(12345, result); // Check if ProdId is correctly assigned
        }

        [TestMethod]
        public void TestMinProdId()
        {
            // Arrange
            var product = new Product(5, "Product B", 200, 30);

            // Act
            var result = product.ProdId;

            // Assert
            Assert.AreEqual(5, result); // Check if ProdId is correctly assigned (min boundary)
        }

        [TestMethod]
        public void TestMaxProdId()
        {
            // Arrange
            var product = new Product(50000, "Product C", 1500, 100);

            // Act
            var result = product.ProdId;

            // Assert
            Assert.AreEqual(50000, result); // Check if ProdId is correctly assigned (max boundary)
        }

        // Test for ProdName
        [TestMethod]
        public void TestValidProdName()
        {
            // Arrange
            var product = new Product(12345, "Product A", 100, 50);

            // Act
            var result = product.ProdName;

            // Assert
            Assert.AreEqual("Product A", result); // Check if ProdName is correctly assigned
        }

        [TestMethod]
        public void TestProdNameNotEmpty()
        {
            // Arrange
            var product = new Product(12345, "Product B", 200, 30);

            // Act
            var result = product.ProdName;

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result)); // Ensure ProdName is not empty
        }

        [TestMethod]
        public void TestProdNameLength()
        {
            // Arrange
            var product = new Product(12345, "Product C", 300, 40);

            // Act
            var result = product.ProdName.Length;

            // Assert
            Assert.IsTrue(result > 0 && result <= 50); // Ensure ProdName length is reasonable
        }



        // These unit tests are created to check how well the 'Product' class methods 'IncreaseStock' and 'DecreaseStock' work.
        // We want to ensure these methods update the stock amount correctly, follow the defined rules, and prevent invalid operations.

        // why I chose these tests??
        // 1. First, I’m testing that the 'IncreaseStock' method properly increases the stock amount by the given value,. 
        // 2. Then, I’m checking that 'IncreaseStock' does not allow negative values and does not exceed the maximum stock limit.m
        // 3. Next, I’m testing that the 'DecreaseStock' method correctly reduces the stock amount by the given value.,..
        // 4. Finally, I’m ensuring that 'DecreaseStock' does not allow negative values and prevents the stock from dropping below zero. ,.

        // Written by Talha: These tests are important to confirm that stock management in the Product class works as expected,
        // preventing incorrect stock updates and ensuring business rules for inventory control are followed.


        [TestMethod]
        public void TestIncreaseStock_ShouldIncreaseStockByGivenAmount()
        {
            var product = new Product(1001, "Laptop", 1000, 50);
            
            product.IncreaseStock(20);
            Assert.AreEqual(70, product.StockAmount);
        }


        [TestMethod]
        public void TestIncreaseStock_ShouldNotExceedMaximumStockLimit()
        {
            
            var product = new Product(12345, "Product A", 100, 500000);

            // Act
            product.IncreaseStock(10);
            Assert.AreEqual(500000, product.StockAmount); 
        }

        [TestMethod]
        public void TestIncreaseStock_ShouldNotAllowNegativeIncrease()
        {
            // Arrange
            var product = new Product(12345, "Product A", 100, 50);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => product.IncreaseStock(-10)); 
        }




        // for DecreaseStock... 3 testss are

        [TestMethod]
        public void TestDecreaseStock_ShouldReduceStockByGivenAmount()
        {
            var product = new Product(1002, "Phone", 500, 50);
            product.DecreaseStock(20);
            
            
            Assert.AreEqual(30, product.StockAmount);
        }

        [TestMethod]
        public void TestDecreaseStock_ShouldNotAllowStockToGoBelowZero()
        {
            var product = new Product(12345, "Product A", 100, 10);

            // Act
            product.DecreaseStock(20); 

            Assert.AreEqual(0, product.StockAmount); 
        }

        [TestMethod]
        public void TestDecreaseStock_ShouldNotAllowNegativeDecrease()
        {
            var product = new Product(12345, "Product A", 100, 50);
// Act & Assert
            Assert.ThrowsException<ArgumentException>(() => product.DecreaseStock(-10)); // this is Checkuing that negative decrease throws exception
        }

    }
}
