using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Supplier
    {
         
        public string Name { get; set; }    
        // S-TwoDigits
        static int NumberOfSupplier = 1;
        public int ID { get{return ID;} private set{ID = NumberOfSupplier;} }
        public List<string> PhoneNumbers;
        public List<Supplier_Bill> bills;
        public Category category;
        public Supplier()
        {
            NumberOfSupplier++;
            PhoneNumbers = new List<string>();
            bills = new List<Supplier_Bill>();
            category = new Category();
            Name = "hamdy";
        }
       
    }
}
