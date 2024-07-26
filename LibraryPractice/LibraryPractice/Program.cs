﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kullanıcı adı kontrol.

            Library kutuphane = new Library();
            Console.WriteLine("Kullanıcı adınızı giriniz");
            string kadi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string sifre = Console.ReadLine();

            kutuphane.UserCheck(kadi, sifre);

            #endregion
            if (kadi == "admin" && sifre == "1234")
            {

                string devam = "e";
                while (devam == "e")
                {
                    Book kitap = new Book();
                    Console.WriteLine("Kitap adı giriniz: ");
                    kitap.bookName = Console.ReadLine();
                    Console.WriteLine("Kitap yazar adı giriniz: ");
                    kitap.bookAuthor = Console.ReadLine();
                    Console.WriteLine("Kitap türü giriniz: ");
                    kitap.bookType = Console.ReadLine();
                    Console.WriteLine("Kitap fiyatı giriniz: ");
                    kitap.bookPrice = Convert.ToDouble(Console.ReadLine());

                    kutuphane.AddBook(kitap);


                    Console.WriteLine("Kitap eklemeye devam etmek istiyor musunuz? ");
                    devam = Console.ReadLine();
                }
            }

        }
    }
}
