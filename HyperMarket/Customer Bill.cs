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
        public int CustomerId { get; set; }  
        public String CustomerName { get; set; }
        public int CashierId { get; set; }
        public string CashierName { get; set; }
        public List<ProductNeed> Customer_Product = new List<ProductNeed>();
        public decimal TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public Customer_Bill()
        {
            NumberOfBills++;
        }
       
       
        public void Edit(/*Customer_Product*/)
        {
            // For editing the amount of customer product "Buy"
        }
        public void AddProduct(ProductNeed p)
        {
            this.Customer_Product.Add(p);
        }
        //Remove Product
        public void DeleteProduct(ProductNeed p)
        {
            this.Customer_Product.Remove(p);
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
