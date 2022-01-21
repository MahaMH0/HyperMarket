using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Casher
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkingHours { get; set; }
        public string Phone { get; set; }
        public float Salary { get; set; }
        public List<Product> Products=new List<Product>();
        //Check For Product's Existance
        public bool ProductIsExist(Product product,Category category)
        {
            foreach(Product p in category.Products)
            {
                if(p.ID == product.ID)
                {
                    return true;
                }
            }
            return false;
        }
        //create Customer Bill
        public void CreateBill(Customer customer)
        {
            customer.bill.CustomerId = customer.ID;
            customer.bill.CashierId = this.ID;
            customer.bill.Products = this.Products;
            foreach(Product p in this.Products)
            {
                customer.bill.TotalPrice += p.PriceForSell;
            }
        }
        //Add Product
        public void AddProduct(Product p)
        {
            Products.Add(p);
        }
        //Remove Product
        public void DeleteProduct(Product p)
        {
            Products.Remove(p);
        }
    }
}
