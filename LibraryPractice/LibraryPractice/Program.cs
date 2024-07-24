using System;
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

            string devam = "e";

            Library kutuphane = new Library();
            Console.WriteLine("1) kitap listesi");
            Console.WriteLine("2) türe göre arama");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                kutuphane.ListBook();
            }
            else if (secim == "2")
            {
              
                kutuphane.ListByType();
            }
            else
            {
                Console.WriteLine("hatalı giriş yaptınız");
            }



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
