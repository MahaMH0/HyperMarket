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
        public string NickName
        {
            get
            {
                return "Admin";
            }
        }
        List<Supplier> Suppliers = new List<Supplier>();
        List<Category> Categories = new List<Category>();
        //create Supplier Bill
        public void CreateSupplierBill(Supplier supplier)
        {
            supplier.bill.SupplierId = supplier.ID;
            supplier.bill.Products = supplier.Products;
            supplier.bill.category = supplier.category;
            foreach (Product p in supplier.Products)
            {
                supplier.bill.TotalPrice += p.PriceForSell;
            }
        }
        //Add Supplier
        public void AddSupplier(Supplier supplier)
        {
            Suppliers.Add(supplier);
        }
        //Remove Supplier
        public void DeleteSupplier(Supplier supplier)
        {
            Suppliers.Remove(supplier);
        }
        //Search For Supplier
        public bool SupplierIsExist(Supplier supplier)
        {
            foreach(Supplier S in Suppliers)
            {
                if (S.SupplierId == supplier.ID)
                    return true;
            }
            return false;
        }
        //Add New Category
        public void AddNewCategory(Category newcategory)
        {
            Categories.Add(newcategory);
        }
        //Add New Product
        public void AddNewProduct(Category category,Product newproduct)
        {
            category.AddProduct(newproduct);
        }
        //Pay Salaries For Employees
        public void PaySalary(Casher casher)
        {
            casher.Salary = 5000;
        }
    }
}

