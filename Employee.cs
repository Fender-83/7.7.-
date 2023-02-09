using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
    public class Employee : Person

    {
        public string JobTittle { get; set; }

        public int PayRoll { get; set; }

        public Delivery CreateDelivery<T>(Address address, Order order, string deliveryCompany, Employee employee) where T : Delivery
        {
            Delivery delivery;
            if (string.IsNullOrEmpty(deliveryCompany) && employee != null)
            {
                delivery = (T)Activator.CreateInstance(typeof(T), new object[] { address, order, employee });
            }
            else
            {
                delivery = (T)Activator.CreateInstance(typeof(T), new object[] { address, order, deliveryCompany });
            }
            return delivery;
        }

        public void Delive(ShopDelivery shopDelivery)
        {
            shopDelivery.FinishDelivery();
        }
    }
}
