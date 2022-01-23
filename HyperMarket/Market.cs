using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Market
    {
         //singlton ISA
        public decimal Budget { get; set; }
        public string Name { get; set; }
        public List<Category> Categories;
        public List<Customer> Customers;
        public List<Supplier> Suppliers ;
        public List<Casher> Cashers ;
        public Market()
        {
            Budget = 1500000;
            Name = "United Group";
            Categories = new List<Category>();
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();
            Cashers = new List<Casher>();
        }
    }
}
