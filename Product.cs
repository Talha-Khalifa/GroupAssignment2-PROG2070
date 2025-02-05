using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }  
        public int ItemPrice { get; set; }
        public int StockAmount { get; set; }

      
        public Product(int prodId, string prodName, int itemPrice, int stockAmount)
        {
            ProdId = prodId;  
            ProdName = prodName;  
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        
        public void IncreaseStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to increase cannot be negative");
            }

            if (StockAmount + amount > 500000)
            {
                StockAmount = 500000; 
            }
            else
            {
                StockAmount += amount;
            }
        }

        
        public void DecreaseStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to decrease cannot be negative");
            }

            if (StockAmount - amount < 0)
            {
                StockAmount = 0; 
            }
            else
            {
                StockAmount -= amount;
            }
        }
    }
}
