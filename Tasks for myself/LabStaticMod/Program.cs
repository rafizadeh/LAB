using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStaticMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student rauf = new Student("Rauf", "Rafizade", 20);
            Student aydan = new Student("Aydan", "Ahadzade", 21);
            Student xxx = new Student("Aydan", "Ahadzade", 21);
            //Console.WriteLine(aydan.Id);
            //Console.WriteLine(xxx.Id);

            //Person.Hello();
            Console.WriteLine(rauf);

            Library library = new Library();
            Book book = new Book();
            book.Name = "Animal farm";

            library[0] = book;
            Console.WriteLine(library[0]);


        }
         
    }

    static class Person
    {
        static Person()
        {
            Console.WriteLine("i am a static constructor");
        }
        public static string Name;

        public static void Hello()
        {
            Console.WriteLine("");
        }
    }
    
    public class Library
    {
        static int index = 0;

        public string Name { get; set; }

        public string Address { get; set; }

        private Book[] books;

        public Book this[int i]
        {
            get
            {
                return books[i];
            }
            set
            {
                books[i] = value;
            }
        }

        public Library()
        {
            books = new Book[1000];
        }
        public void AddBooks(Book book)
        {
            books[index] = book;
            index++;
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public int PageCount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }



}
