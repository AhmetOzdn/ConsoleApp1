using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Id = 1;
            Product1.CategoryId = 2;
            Product1.ProductName = "Masa";
            Product1.UniPrice = 500;
            Product1.UnitsInStocks = 3;

            // yukarıdaki  veya aşağıdaki gibi yazılabilir

            Product product2 = new Product { Id = 2 , CategoryId = 3 , ProductName = "Sandalye" , UniPrice = 35 , UnitsInStocks=5};

            //Pascal Case  // Camel Case
            //Case senstive
            ProductManager Productmanager = new ProductManager();
            Productmanager.Add(Product1);
            


            // Sayısallar(int,bool,...)-->Değer Tipleridir
            // Diziler,Class,Abstract Class,Interface...>Referans Tiplerdir
            //ref out keys
        }
    }
}
