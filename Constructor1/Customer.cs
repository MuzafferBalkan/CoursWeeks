using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1
{
    class Customer
    {
        public Customer(string ad,string soyad,int yas)
        {
            Name = ad;
            LastName = soyad;
            Age = yas;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
