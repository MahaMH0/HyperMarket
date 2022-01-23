using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Category
    {
        public string Name { get; set; }
        //C-TwoDigit
        public string ID { get; set; }
        public List<Supplier> suppliers { get; set; }
        public List<Product> Products{ get; set; }
        public void AddProduct(Product product)
        {
            if (this.Products.Contains(product))
            {
                foreach (Product product1 in Products)
                {
                    if (product.ID == product1.ID)
                            product1.IncreaseAmount(product.Amount);
                }
            }
            else
            {
                this.Products.Add(product);
            }

        }
        public void RemoveProduct(Product product)
        {
            this.Products.Remove(product);
        }
        public Category(string Name , string ID ,List<Supplier> suppliers)
        {
            this.Name = Name;
            this.ID = ID;   
            foreach(var i in suppliers)
            {
                this.suppliers.Add(i);  
            }
        }
        public override string ToString()
        {
            return $"Name of category => {Name}\nID of category => {ID}\n";
        }
    }
}
