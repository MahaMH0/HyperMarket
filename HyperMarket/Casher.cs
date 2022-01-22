﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket
{
    internal class Casher
    {
        public string Name { get; set; }
        static int  NumberOfCashers = 1;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkingHours { get; set; }
        public List<string> Phone ;
        public float Salary { get; set; }

        //public List<ProductNeed> Products=new List<ProductNeed>();
        //Check For Product's Existance
        public Casher() //:this($"hamdy{this.ID}" ,$"cashier{this.ID}" ,"root" , 12 , new List<string>{ "0100005558"}  , 2500.0)
            {
                NumberOfCashers++;
            }
        public Casher  (string Name , String UserName , String Password , int WorkingHours ,List<String> phone , float Salary)
            {
                NumberOfCashers++;
                this.WorkingHours = WorkingHours;
                this.Salary = Salary;
                this.Password = Password;
                this.Username = UserName;
                this.Phone =new List<string>();
                foreach (string p in phone)
                {
                    this.Phone.Add(p);
                }
            }

        //check existance of product search 
        public bool ProductIsExist(Product product,Category category)
        {
            foreach(Product p in category.Products)
            {
                if(p.ID == product.ID)
                {
                    return true;
                }

            }
            return false;
        }

        // check existance of product and it's amount covered the customer Need

        public bool ProductCoverd(ProductNeed product,Category category)
        {
            foreach(Product p in category.Products)
            {
                if(p.ID == product.Product.ID)
                {
                    if(p.Amount >= product.AmountNeeded)
                    return true;
                }

            }
            return false;
        }
  
        //check if customer is not exist in customer List or not before adding
        public void AddCustomer(Market market, Customer customer)
        {
           if(!market.Customers.Contains(customer))
            {
                market.Customers.Add(customer);
            }

            int index = market.Customers.IndexOf(customer);
            customer = market.Customers[index];
        }
        //create Customer Bill
        public void CreateBill(Customer customer)
        {
            Customer_Bill customer_Bill = new Customer_Bill();
            customer_Bill.CashierId = this.ID;
            customer_Bill.CustomerId = customer.ID;
            customer_Bill.CashierName = this.Name;
            customer_Bill.CustomerName = customer.Name;
            customer.bills.Add(customer_Bill);
        }

       
        //edit amount of existance product
        public void EditProduct(ProductNeed pnew , Customer customer)
        {   
            if(pnew.AmountNeeded >0)
            { 
                 int index = customer.bills[customer.bills.Count - 1].Customer_Product.IndexOf(pnew);
                if(index>0)
                customer.bills[customer.bills.Count - 1].Customer_Product[index].AmountNeeded = pnew.AmountNeeded;
            }
            else
            {
                DeleteProduct(pnew , customer);
            }
        }

        //adding product to the last added  cutomer's bill and throw exception if 
       // the product couldn't cover amount or not exist

        public void AddProduct(ProductNeed p , Customer customer)
        {
            ProductNeed check = p;
            //check if the product is already exist in customer basket
            if(customer.bills[customer.bills.Count - 1].Customer_Product.Contains(p)) // 
            {
                int index = customer.bills[customer.bills.Count - 1].Customer_Product.IndexOf(p);
                if(index>0)
                check.AmountNeeded += customer.bills[customer.bills.Count - 1].Customer_Product[index].AmountNeeded;
                
                if (this.ProductCoverd(check , check.Product.category)) 
                { 
                    
                    customer.bills[customer.bills.Count - 1].Customer_Product[index].AmountNeeded += p.AmountNeeded;
                }
                else
                { 
                    throw new Exception("product Not cover");
                }
            }
            // for first time adding product to our basket
            else if (this.ProductCoverd(p , p.Product.category))
            {   
                    customer.bills[customer.bills.Count - 1].Customer_Product.Add(p);
            }
            else
                throw new Exception("product Not cover");

        }
        //Remove product to the last added  cutomer's bill 
        public void DeleteProduct(ProductNeed p , Customer customer)
        {
            customer.bills[customer.bills.Count - 1].Customer_Product.Remove(p);
        }

        //remove that bill "لو الكستمر رجع ف كلامه"

        public void FinalDeletForBill(Customer customer)
        {
            customer.bills.Remove(customer.bills[customer.bills.Count - 1]);
        }

        //Complete the payment basket list of product every prodct have amount and price 
        // and decrease amount of stock products in market
        public void pay(Market market , Customer customer)
        {
            //increase budget 
           decimal total = 0;
            foreach(ProductNeed p in customer.bills[customer.bills.Count - 1].Customer_Product)
            {
                total += (p.AmountNeeded * p.Product.PriceForBuy);
            }
            customer.bills[customer.bills.Count - 1].TotalPrice = total;

            market.Budget += total;

            // decrease amount of products
            foreach (ProductNeed item in customer.bills[customer.bills.Count - 1].Customer_Product)
            {
              int catIndex = market.Categories.IndexOf(item.Product.category);
              int ProdIndex = market.Categories[catIndex].Products.IndexOf(item.Product);  
              market.Categories[catIndex].Products[ProdIndex].Amount -= item.AmountNeeded;

            }

        }

        
     
    }
}
