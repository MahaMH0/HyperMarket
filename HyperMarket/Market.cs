using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{      
    internal sealed class Market
    {
        //singlton ISA
        public double Budget { get; set; }
        public string Name { get; set; }
        public List<Category> Categories;
        public List<Customer> Customers;
        public List<Supplier> Suppliers ;
        public List<Casher> Cashers ;
        private Market() 
        {
            Budget = 1500000;
            Name = "United Group";
            Categories = new List<Category>();
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();
            Cashers = new List<Casher>();


        }
        private static Market mark = null;
        public static Market market { 
        get {
                if (mark == null)
                {
                    mark = new Market();
                }
                    return mark;
            }
        }
       

    }
}
