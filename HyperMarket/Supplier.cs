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
        public string ID { get; set; }
        public List<string> PhoneNumbers;
        public Supplier_Bill bill ;
        public List<Product> Products ;
        public Supplier()
        {
            PhoneNumbers = new List<string>();
            bill = new Supplier_Bill();
            Products = new List<Product> ();
        }
      // Category (name)
    }
}
