using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // (ctrl+k)+(ctrl+c) toplu bir şekilde seçtiğiniz bloğu komut blokları arasına alır.
            //Console.WriteLine(isimler[2]);  // (ctrl+k)+(ctrl+u) toplu kontrol bloğunu iptal eder

            //string[] isimler = new string[] { "Berke", "Fatma", "Sengül", "Deniz" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[3]);

            // {} bloklarından yukarıdaki array gibi eleman ekleyebiliriz. tabi () bunlar kalkar

            List<string> isimler2 = new List<string> { "Berke", "Fatma", "Sengül", "Deniz" };  // {} bloklarından yukarıdaki array gibi eleman ekleyebiliriz. tabi () bunlar kalkar
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
