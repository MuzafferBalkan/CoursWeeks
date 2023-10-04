using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
      
    }
}
