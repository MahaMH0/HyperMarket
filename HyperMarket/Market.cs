using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Market
    {
        public double Budget { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
       // public List</* stock Products*/> StockProducts { get; set; }
       public List<Supplier_Bill> Supplier_Bills { get; set; }
        public List<Customer_Bill> Customer_Bills { get; set;}

    }
}
