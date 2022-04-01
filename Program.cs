using AbstractClass.AbstractClass;
using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi daxil edin");
            Product book = new Product(3241, "Abcd", 12.5, 20);
            Book book1 = new Book("Detective", 3241, "Abcd", 12.5, 20);
        }
    }
}
