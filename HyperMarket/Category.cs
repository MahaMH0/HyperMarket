using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Category
    {
        public string Name { get; set; }
        //C-TwoDigits
        public string ID { get; set; }
        public List<Supplier> suppliers { get; set; }
       // public List<Stock_product> Stock_Product{ get; set;}
        // LIST OF PRODUCTS (WAITING)
        public int NumberOfProducts { get; set; }


        public Category(string Name , string ID , int NumberOfProducts ,List<Supplier> suppliers)
        {
            this.Name = Name;
            this.ID = ID;   
            this.NumberOfProducts = NumberOfProducts;   
            foreach(var i in suppliers)
            {
                this.suppliers.Add(i);  
            }
        }
        public override string ToString()
        {
            return $"Name of category => {Name}\nID of category => {ID}\nNumber of products => {NumberOfProducts}\n";
        }
    }
}
