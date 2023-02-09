using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
    public abstract  class OrderBase
    { 

        public int Number;

        public string Description;
       
        public Customer Customer { get; set; }
        public Shop Shop { get; set; }
        public Employee Employee { get; set; }
        public double PriceTotal { get; set; }
        public bool IsPayed { get; set; }
        public List<Product> Products { get; set; }
        public Delivery Delivery { get; set; }

        public OrderBase() 
        {
            Products = new List<Product>();
        }

        internal void SetTotalPrice()
        {
            double totalPrice = 0;
            if (Products.Count > 0)
            {
                foreach (var item in Products)
                {
                    totalPrice += item.Price;
                }
            }
            PriceTotal = totalPrice;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}
