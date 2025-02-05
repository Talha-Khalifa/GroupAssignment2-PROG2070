using Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
