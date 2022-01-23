using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Manager
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }


        public Manager()
        {
            Name ="Admin";
            UserName ="Admin";
            Password = "Admin";
            ID = 255;
        }
        //add new Cashier
        public void AddCashier(Market market , Casher casher)
        {
            if(!market.Cashers.Contains(casher))
            {
                market.Cashers.Add(casher);
            }
        }
        // add new Supplier
        public void AddSupplier(Market market , Supplier supplier)
        {
            if(!SupplierIsExist(market , supplier))
            {
                market.Suppliers.Add(supplier);
            }
        }

        //Add category to categories if is not exist
        public void AddCategory(Market market , Category category)
        {
            if(!CategoryIsExist(market , category))
            {
                market.Categories.Add(category);
            }
        }

        //create Supplier Bill
       public void CreateBill(Supplier supplier)
        {
            Supplier_Bill Supplier_Bill = new Supplier_Bill();
            Supplier_Bill.SupplierId = supplier.ID;
            Supplier_Bill.SupplierName = supplier.Name;
            supplier.bills.Add(Supplier_Bill);
        }

        //Remove Supplier
        public void DeleteSupplier(Market market , Supplier supplier)
        {
            if(SupplierIsExist(market , supplier))
            market.Suppliers.Remove(supplier);
        }

        //Remove category
        public void DeleteCategory(Market market , Category category)
        {
            if(CategoryIsExist(market , category))
            market.Categories.Remove(category);
        }

        //Search For Supplier
        public bool SupplierIsExist(Market market, Supplier supplier)
        {
            return market.Suppliers.Contains(supplier);
        }

        //search for category
        public bool CategoryIsExist(Market market, Category category)
        {
            return market.Categories.Contains(category);
        }

        //Add product to supplier-list
        public void AddSupplierProduct(Market market , Supplier supplier , ProductNeed product)
        {
            int lastBillIndex = supplier.bills.Count - 1; 
            if(supplier.bills[lastBillIndex].Supplier_Product.Contains(product))
            {
                ProductNeed che = product;
                int ProductIndex = supplier.bills[lastBillIndex].Supplier_Product.IndexOf(product);
                che.AmountNeeded += supplier.bills[lastBillIndex].Supplier_Product[ProductIndex].AmountNeeded;
                RemoveSupplierProduct(supplier , product);
                AddSupplierProduct(market ,supplier , che);
            }
            else
            {
                decimal oldTotalPrice = supplier.bills[lastBillIndex].TotalPrice;

                decimal newTotalPrice = 0;

                newTotalPrice += product.AmountNeeded * product.Product.PriceForBuy;
                if(CheckBudgedCovered(market , newTotalPrice))
                { 
                    supplier.bills[lastBillIndex].Supplier_Product.Add(product);
                    supplier.bills[lastBillIndex].TotalPrice = newTotalPrice;
                }
                else
                {
                    //warning if the budget
                    throw new Exception("budget not cover this amount of products");
                }
                
            }
        }

        //Remove product from supplier bill
        public void RemoveSupplierProduct(Supplier supplier , ProductNeed product)
        {
            int lastBillIndex = supplier.bills.Count - 1; 
            supplier.bills[lastBillIndex].Supplier_Product.Remove(product);

            int productIndex = supplier.bills[lastBillIndex].Supplier_Product.IndexOf(product);

            int amountNeeded = supplier.bills[lastBillIndex].Supplier_Product[productIndex].AmountNeeded;

            decimal priceOfbuy = supplier.bills[lastBillIndex].Supplier_Product[productIndex].Product.PriceForBuy;

            decimal priceOfRemovedProduct = priceOfbuy * (decimal) amountNeeded ;
            
            supplier.bills[lastBillIndex].TotalPrice -= priceOfRemovedProduct;

        }
       //check budget covered 
        public bool CheckBudgedCovered(Market market ,decimal billprice)
        {
            decimal total = 0;
           return ((market.Budget - billprice) >= 0) ? true : false;
        }
        //paymnet to supplier
        public void pay(Market market , Supplier supplier)
        {
            //decrease Budget amount
            int lastBillIndex = supplier.bills.Count - 1;
            market.Budget -= supplier.bills[lastBillIndex].TotalPrice;
            
            //increase amount of product in Category
            foreach(ProductNeed item in supplier.bills[lastBillIndex].Supplier_Product)
            {
               Category cat = item.Product.category;
               int indexofcat = market.Categories.IndexOf(cat);
               int indexOfProduct =  market.Categories[indexofcat].Products.IndexOf(item.Product);
               market.Categories[indexofcat].Products[indexOfProduct].Amount += item.AmountNeeded;
            }


        }
    }
}

