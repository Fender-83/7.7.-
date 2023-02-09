using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
    public class Order: OrderBase
    { 
      
        public Order() : base() { }

        public Order(Employee employee, Customer customer, Shop shop) : base()
        {
            Employee = employee;
            Customer = customer;
            Shop = shop;
        }


        public void AddProduct(Product product)
        {
            Products.Add(product);
            SetTotalPrice();
        }



    }
}
