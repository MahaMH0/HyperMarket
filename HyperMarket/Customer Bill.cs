using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Customer_Bill
    {
        static int NumberOfBills = 0;
        public int BillId {
            get
            {
                return BillId;  
            }
            set
            {
                BillId = NumberOfBills;
            }
        }
        public String CustomerId { get; set; }  
        public String CustomerName { get; set; }
        public String CashierId { get; set; }
        public string CashierName { get; set; }
        List<ProductNeed> Customer_Product { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public Customer_Bill()
        {
            NumberOfBills++;
        }
       
        public void Add(/*Customer_Product*/)
        {
            
        }
        public void Edit(/*Customer_Product*/)
        {
            // For editing the amount of customer product "Buy"
        }
        public void Delet(/*Customer_Product*/)
        {

        }
        public void FinalDeletForBill()
        {
            NumberOfBills--;
            //foreach(var i in /*list of Customer_Product*/)
            //{
            //    // Use delet function 
            //}
        }

        //Pay -> Budget -->Amount Product ?????

    }
}
