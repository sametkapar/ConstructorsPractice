using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Library
    {
        public Book[] books;
        public Users[] users;

        public Library()
        {

            #region Kitaplar



            books = new Book[5];

            Book kitap = new Book();
            kitap.bookName = "Karamazov Kardeşler";
            kitap.bookAuthor = "Dostoyevski";
            kitap.bookType = "roman";
            kitap.bookPrice = 200;
            books[0] = kitap;

            Book kitap2 = new Book();
            kitap2.bookName = "Yüzüklerin Efendisi";
            kitap2.bookAuthor = "J.R.R. Tolkein";
            kitap2.bookType = "roman";
            kitap2.bookPrice = 550;
            books[1] = kitap2;

            Book kitap3 = new Book();
            kitap3.bookName = "Death Note";
            kitap3.bookAuthor = "Tsugumi Ooba";
            kitap3.bookType = "manga";
            kitap3.bookPrice = 77;
            books[2] = kitap3;
            Book kitap4 = new Book();
            kitap4.bookName = "Akışkanlar Mekaniği";
            kitap4.bookAuthor = "Jhon M. Cimbalak, Yunus Çengel";
            kitap4.bookType = "ders";
            kitap4.bookPrice = 830;
            books[3] = kitap4;
            Book kitap5 = new Book();
            kitap5.bookName = "Kavgam";
            kitap5.bookAuthor = "Adolf Hitler";
            kitap5.bookType = "otobiyografi";
            kitap5.bookPrice = 85;
            books[4]= kitap5;
            #endregion

            #region Kullanıcılar

            users = new Users[3];
            Users user1 = new Users();
            user1.name = "admin";
            user1.pass = "1234";
            users[0] = user1;
            Users user2 = new Users();
            user2.name = "samet";
            user2.pass = "0000";
            users[1] = user2;
            Users user3 = new Users();
            user3.name = "mevlüt";
            user3.pass = "9999";
            users[2] = user3;

            #endregion

        }

        #region UserCheck
        public void UserCheck(string kadi, string sifre)
        {

            int index = -1;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].name == kadi)
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
                if (users[index].pass == sifre)
                {
                    if (kadi == users[0].name && sifre == users[0].pass)
                    {
                        Console.WriteLine("Admin Girişi yapıldı");

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

                            AddBook(kitap);


                            Console.WriteLine("Kitap eklemeye devam etmek istiyor musunuz? ");
                            devam = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı Girişi yapıldı");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("1) Kitap Listesi");
                        Console.WriteLine("2) Türe göre kitap listesi");
                        Console.WriteLine("Lütfen seçim yapınız");
                        string secim = Console.ReadLine();
                      
                        if (secim == "1")
                        {
                            ListBook();
                        }
                        else
                        {
                            TypeListing();
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

        #region Kitap ekleme

        public void AddBook(Book p_kitap)
        {
            Book[] gecici = new Book[books.Length + 1];

            Array.Copy(books, gecici, books.Length);

            gecici[gecici.Length - 1] = p_kitap;

            books = gecici;
        }

        #endregion

        #region BookListing
        public void ListBook()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"---{(i + 1)}---\nİSİM: {books[i].bookName}\n-YAZAR: {books[i].bookAuthor}\n-TÜR: {books[i].bookType}\n-FİYAT:{books[i].bookPrice} TL");
                Console.WriteLine("");
            }
        }

        #endregion

        #region TypeListing
        public void TypeListing()
        {
            string[] types = new string[books.Length];
            int checkIndex = 0;

            for (int i = 0; i < books.Length; i++)
            {
                bool isIN = false;
                for (int j = 0; j < types.Length; j++)
                {
                    if (books[i].bookType == types[j])
                    {
                        isIN = true;
                        break;
                    }
                }
                if (isIN == false)
                {
                    types[checkIndex] = books[i].bookType;
                    checkIndex++;
                    Console.WriteLine(books[i].bookType);

                }
            }
        }

        #endregion

        #region TypeSearch

        public void ListByType()
        {
            
            Console.WriteLine("Lütfen aramak istediğiniz türü giriniz ");
            string secim = Console.ReadLine();
            secim = secim.ToLower();
            Console.WriteLine(secim + " Türü kitaplar");
            Console.WriteLine("----------------------");
            for (int i = 0; i < books.Length; i++)
            {
                if (secim == "roman" && books[i].bookType == secim)
                {
                    Console.WriteLine((i + 1) + ") " + books[i].bookName);
                }
                else if (secim == "ders" && books[i].bookType == secim)
                {
                    Console.WriteLine((i + 1) + ") " + books[i].bookName);
                }
                else if (secim == "manga" && books[i].bookType == secim)
                {
                    Console.WriteLine((i + 1) + ") " + books[i].bookName);
                }
                else if (secim == "otobiyografi" && books[i].bookType == secim)
                {
                    Console.WriteLine((i + 1) + ") " + books[i].bookName);
                }
            }
        }
        #endregion
    }
}

