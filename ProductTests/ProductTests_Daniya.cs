using NUnit.Framework;
using Assignment2; 
//Daniya Shaji 
namespace ProductTests
{
    [TestFixture] 
    public class Tests
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            // Initializes a defaut product before each test
            product = new Product(101, "Laptop", 1000, 50);
        }

        // ✅ Test 1: IncreaseStock() should correctly increease stock
        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            // Act
            product.IncreaseStock(25);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(75));
        }

        // ✅ Test 2: IncreseStocks() should not allow negativ values
        [Test]
        public void IncreaseStock_NegativeAmount_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.IncreaseStock(-10));
        }

        // ✅ Test 3: IncreaseStock() should not allow 0 increase
        [Test]
        public void IncreaseStock_ZeroAmount_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.IncreaseStock(0));
        }

        // ✅ Test 4: DecreaseStock() should correctly reduecs stock
        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            // Act
            product.DecreaseStock(10);

            // Assert
            Assert.That(product.StockAmount, Is.EqualTo(40));
        }

        // ✅ Test 5: DecreaseStock() should not allow reducing more than availabile stock
        [Test]
        public void DecreaseStock_ExceedingStock_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(60));
        }

        // ✅ Test 6: DecreaseStock() should not allow negative values
        [Test]
        public void DecreaseStock_NegativeAmount_ShouldThrowException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.DecreaseStock(-5));
        }
    }
}
