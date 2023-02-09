using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
    public class Customer : Person
    {
        public string CreditCart { get; set; }

        public void Pay(Order order)
        {
            order.IsPayed = true;
        }
    }
}
