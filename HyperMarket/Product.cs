using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public decimal PriceForBuy { get; set; }
        public decimal PriceForSell { get; set; }
        public Category category { get; set; }
        public long Amount { get; set; }
        public DateTime ExpireDate { get; set; }
        public void IncreaseAmount(long amount)
        {
            this.Amount += amount;
        }
        public void DecreaseAmount(long amount)
        {
            this.Amount -= amount;
        }

    }
}
