using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Supplier_Bill
    {
        public Supplier SupplierData { get; set; }
        static int NumberOfSupplierBills = 0;
        public int SupplierBillID
        {
            get
            {
                return SupplierBillID;
            }
            set
            {
                SupplierBillID = NumberOfSupplierBills;
            }
        }
        public DateTime CreationDate { get; set; }
        public Supplier_Bill()
        {
            NumberOfSupplierBills++;
        }
      //  public List</*Stock Products*/> StockProuct { get; set; }
        public double TotalPrice { get; set; }

        public void Add(/*Stock_Product*/)
        {

        }
        public void Edit(/*Stock_Product*/)
        {
            // For editing the amount of customer product "Buy"
        }
        public void Delet(/*Stock_Product*/)
        {

        }
        //pay -> budget -- Amount of products || category

    }
}
