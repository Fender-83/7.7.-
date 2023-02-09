using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
    public class Shop
    {
        private int OrderNumber = 1;
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }


        public Order CreateOrder()
        {
            var order = new Order();
            order.Shop = this;
            order.Number = OrderNumber;
            Orders.Add(order);
            OrderNumber++;  
            return order;
        }

        public Order CreateOrder(Employee employee, Customer customer)
        {
            var order = new Order(employee, customer, this);
            Orders.Add(order);
            OrderNumber++;
            Orders.Add(order);
            return order;
        }

        
    }
}
