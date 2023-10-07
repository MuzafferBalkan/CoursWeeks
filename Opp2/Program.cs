using System;

namespace Opp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muzaffer Balkan
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CostomerNo = "12345";
            customer1.TcNo = "12345678910";
            customer1.FirstName = "Muzaffer";
            customer1.LastName = "Balkan";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CostomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
