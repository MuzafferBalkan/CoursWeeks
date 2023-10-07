using System;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adını Gir : ");
            string Ad = Console.ReadLine();
            Console.WriteLine("Soyadını Gir : ");
            string Soyad = Console.ReadLine();
            Console.WriteLine("Yaşını Gir : ");
            int Yas = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer(Ad,Soyad,Yas);

            Console.WriteLine("Kaydınız Başarıyla Yapılmıştır.");
            Console.WriteLine("Adı : "+customer.Name);
            Console.WriteLine("Soyadı : " + customer.LastName);
            Console.WriteLine("Yaşı : " + customer.Age);

        }
    }
}
