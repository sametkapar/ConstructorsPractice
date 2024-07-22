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

        public Library()
        {
            books = new Book[0];
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
                Console.WriteLine((i+1)+ ")" + books[i].bookType);
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
    }
}

