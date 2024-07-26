using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Library
    {
        public Book[] books;


        public Library()
        {


            books = new Book[3];

            Book kitap = new Book();
            kitap.bookName = "Yüzüklerin Efendisi";
            kitap.bookAuthor = "Tolkein";
            kitap.bookType = "roman";
            kitap.bookPrice = 150;
            books[0] = kitap;

            Book kitap2 = new Book();
            kitap2.bookName = "yaşamak iyidir";
            kitap2.bookAuthor = "BEN TEN";
            kitap2.bookType = "makale";
            kitap2.bookPrice = 235;
            books[1] = kitap2;

            Book kitap3 = new Book();
            kitap3.bookName = "Death Note";
            kitap3.bookAuthor = "Tsugumi Ooba";
            kitap3.bookType = "manga";
            kitap3.bookPrice = 77;
            books[2] = kitap3;

            
        }

        public void AddBook(Book p_kitap)
        {
            Book[] gecici = new Book[books.Length + 1];

            Array.Copy(books, gecici, books.Length);

            gecici[gecici.Length - 1] = p_kitap;

            books = gecici;
        }

        #region BookListing
        public void ListBook()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {books[i].bookName} {books[i].bookAuthor} {books[i].bookType} {books[i].bookPrice}");
            }
        }

        #endregion


        #region TypeListing
        public void ListByType()
        {

            for (int i = 0; i < books.Length; i++)

            {
                Console.WriteLine((i + 1) + ")" + books[i].bookType);
            }

            for (int i = 0; i < books.Length; i++)
            {

                if (books[i].bookType == "roman")
                {

                    Console.WriteLine(books[i].bookName);
                }
                else if (books[i].bookType == "makale")
                {
                    Console.WriteLine(books[i].bookName);
                }
                else
                {
                    Console.WriteLine(".... türüne ait kitap bulunmamaktadır.");
                }



            }
        }

        #endregion


        #region UserCheck
        public void UserCheck(string kadi, string sifre)
        {


            string[] kullanicilar = { "admin", "samet" };
            string[] sifreler = { "1234", "0000" };
            int index = -1;
            for (int i = 0; i < kullanicilar.Length; i++)
            {
                if (kullanicilar[i] == kadi)
                {

                    index = i; break;
                }

            }
            if (index == -1)
            {
                Console.WriteLine("Kullanıcı Bulunamadı Lütfen bilgileri kontrol ediniz");
            }
            else
            {
                if (sifreler[index] == sifre)
                {
                    if (kadi == "admin" && sifre == "1234")
                    {
                        Console.WriteLine("Admin girişi yapıldı");


                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı girişi yapıldı");
                        Console.WriteLine("1) Kitap listesi");
                        Console.WriteLine("2) Türe göre arama");
                        string secim = Console.ReadLine();

                        if (secim == "1")
                        {
                            ListBook();
                        }
                        if (secim == "2")
                        {
                            ListByType();
                        }

                    }
                }
                else
                {
                    {
                        Console.WriteLine("Şifre Hatalı");
                    }
                }


            }
        }
        #endregion
    }
}

