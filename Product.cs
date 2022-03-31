using System;


namespace _31032002.AccessModifiers
{
    class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;
        public bool isExisted;
        public Product(int no, string name, double price)
        {
            Name = name;
            No = no;
            Price = price;
            if (no<=0 || name=="" || price>0)
            {
                Console.WriteLine("Daxil edilen melumatlar duzgun deyil!");
                return;
            }
            isExisted = true;
        }
        public Product(int no, string name, double price,int count)
        {
            Count = count;
        }
    }
}
