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
        //C-TwoDigits
        public string ID { get; set; }
        public List<Supplier> suppliers { get; set; }
        public List<Product> Products{ get; set;}

        private void Add
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
            return $"Name of category => {Name}\nID of category => {ID}\nNumber of products => {NumberOfProducts}\n";
        }
    }
}
