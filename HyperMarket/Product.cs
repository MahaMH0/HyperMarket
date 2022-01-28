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
        public double PriceForBuy{ get; set; }
        public double PriceForSell{ get; set; }
        public string category { get; set; } //category id
        public long Amount { get; set; }
        public DateTime ExpireDate { get; set; }
        public Product(double PriceForBuy, double PriceForSell, long Amount, string Name  , DateTime ExpireDate , string category)
        {
            NumberOfProduct++;
            this.PriceForBuy = PriceForBuy;
            this.Amount = Amount;  
            this.Name = Name;
            this.PriceForSell = PriceForBuy;
            this.ExpireDate = ExpireDate;
            this.category = category;
        }
        public Product()
        {
            NumberOfProduct++;
            PriceForSell = 0;
            PriceForBuy = 0;
            ExpireDate = DateTime.Now;
        }

    } 
}
