using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.Итоги
{
   public  abstract class Person

    {
        public Guid ID { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int TelNumber { get; set; }
        



    }
}
