using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
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
            if (amount > 0)
            {
                StockAmount += amount;
            }
        }

        
        public bool DecreaseStock(int amount)
        {
            if (amount > 0 && StockAmount >= amount)
            {
                StockAmount -= amount;
                return true;
            }
            return false;
        }
    }
}
