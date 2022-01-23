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
        static int NumberOfProduct = 1;
        public string Description { get; set; }
        public int ID { get{return ID;} private set{this.ID = NumberOfProduct;} }
        public decimal PriceForBuy{ get; set; }
        public decimal PriceForSell{ get; set; }
        public Category category { get; set; }
        public long Amount { get; set; }
        public DateTime ExpireDate { get; set; }
        public Product()
        {
            NumberOfProduct++;
            PriceForSell = 0;
            PriceForBuy = 0;
        }

    } 
}
