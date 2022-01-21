using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Customer
    {
       public string Name { get; set; }
       public int ID { get; set; }
       public string Phone { get; set; }
       public int NOPoints { get; set; }
       public Customer_Bill bill = new Customer_Bill();

       public void IncreasePoints()
        {
            ++NOPoints;
        }
    }
}
