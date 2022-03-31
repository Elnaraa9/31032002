using System;


namespace _31032002.AccessModifiers
{
    class Book:Product
    {
        public string Genre;
        public bool Cretaed;
        public Book(string genre, int no, string name, double price, int count): base(no, name, price, count)
        {
            Genre = genre;
            if (genre==""||genre==" ")
            {
                Console.WriteLine("Bele bir janr movcud deyil");
            }
            Cretaed = true;
        }
    }
}
