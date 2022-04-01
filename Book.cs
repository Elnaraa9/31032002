using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.AbstractClass
{
    class Book:Product
    {
        public string Genre;
        public bool Created;
        public Book(string genre, int no, string name, double price, int count) : base(no, name, price, count)
        {
            Genre = genre;
            if (genre == "" || genre == " ")
            {
                Console.WriteLine("Bele bir janr movcud deyil");
            }
            Created = true;
            Book[] book = new Book[count];

        }
    }
}
