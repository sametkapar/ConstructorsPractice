using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Library
    {
        public Book[] books;
        public Book[] users;
        public Library()
        {

            users = new Book[2];
            Book admin = new Book();
            admin.userName = "admin";
            admin.password = "1234";
            users[0] = admin;
            Book user1 = new Book();
            user1.userName = "samet";
            user1.password = "0000";
            users[1] = user1;

            books = new Book[3];

            Book kitap = new Book();
            kitap.bookName = "Yüzüklerin Efendisi";
            kitap.bookAuthor = "Tolkein";
            kitap.bookType = "roman";
            kitap.bookPrice = 150;
            books[0] = kitap;

            Book kitap2 = new Book();
            kitap2.bookName = "yaşamak iyidir";
            kitap2.bookAuthor = "Tolkein";
            kitap2.bookType = "makale";
            kitap2.bookPrice = 150;
            books[1] = kitap2;

            Book kitap3 = new Book();
            kitap3.bookName = "Death Note";
            kitap3.bookAuthor = "Tsugumi Ooba";
            kitap3.bookType = "manga";
            kitap3.bookPrice = 150;
            books[2] = kitap3;
        }

        public void AddBook(Book p_kitap)
        {
            Book[] gecici = new Book[books.Length + 1];

            Array.Copy(books, gecici, books.Length);

            gecici[gecici.Length - 1] = p_kitap;

            books = gecici;
        }
        public void ListBook()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {books[i].bookName} {books[i].bookAuthor} {books[i].bookType} {books[i].bookPrice}");
            }
        }
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

        public void UserCheck(string kadi, string sifre)
        {



        }
    }
}

