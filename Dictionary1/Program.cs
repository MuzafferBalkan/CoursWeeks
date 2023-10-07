using System;
using System.Collections.Generic;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            //Ogrenci.Add(111, "Naruto Uzumaki");
            //Ogrenci.Add(127, "Sasuke Uchiha");
            //Ogrenci.Add(17, "Shisui Uchiha");

            //Console.WriteLine(Ogrenci.Count); 

            //Console.WriteLine("Lütfen aradığınız öğrencinin okul numarasını giriniz : ");
            //int No = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    Console.WriteLine(Ogrenci[No]);
            //}
            //catch
            //{
            //    Console.WriteLine("Arattığınız nurmaraya kayıtlı bir öğrenci bulunamadı.");
            //}
            MyDictionary<int, string> mydictionary = new MyDictionary<int, string>();
            Console.WriteLine("Lütfen kayıt yapmak istediğiniz öğrencinin numarasını giriniz : ");
            int No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kayıt yapmak istediğiniz öğrencinin ismini ve soyismini giriniz : ");
            string AdSoyad = Console.ReadLine();

            mydictionary.Add(No,AdSoyad);
            mydictionary.Listele();

        }
    }
}
