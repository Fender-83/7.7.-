using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{

    public abstract class Delivery
    {
        public Address Address;
        public Order Order { get; set; }

        public DateTime DeliveredAt { get; set; }
        public bool IsSend { get; set; }

        public Delivery(Address address, Order order) 
        {
            Address = address;
            Order = order;
        }

        private void Send()
        {
            IsSend = true;
        }

        public virtual void FinishDelivery()
        {
            DeliveredAt = DateTime.Now;
        }
    }

    public class HomeDelivery : Delivery
    {
        public HomeDelivery(Address address, Order order, string deliveryCompany):base(address, order) { }
        public string DeliveryCompany { get; set; }
    }

    public class PickPointDelivery : HomeDelivery
    {
        public PickPointDelivery(Address address, Order order, string deliveryCompany) : base(address, order, deliveryCompany) { }
        public string RegCode { get; set; }

        public override void FinishDelivery()
        {
            base.FinishDelivery();
            RegCode = "CreateRandomCode";
        }
    }

    public class ShopDelivery : Delivery
    {
        public ShopDelivery(Address address, Order order, Employee employee) : base(address, order) { }
        public Employee Employee { get; set; }
    }

}
