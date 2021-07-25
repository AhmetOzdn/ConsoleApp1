using System;

namespace Yazılım_geliştirici_3.gun
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma" ;
            string Aciklamasi = "Amasya Elması";
            double Fiyat = 15.3 ;

            Product urun1 = new Product();
            urun1.UrununAdi = "Elma";
            urun1.Aciklamasi = "Amasya Elması";
            urun1.Fiyati = 15.3;

            Product urun2 = new Product();
            urun2.UrununAdi = "Karpuz";
            urun2.Aciklamasi = "Diarbakır Karpuzu";
            urun2.Fiyati = 3.25;

            Product urun3 = new Product();
            urun3.UrununAdi = "Patates";
            urun3.Aciklamasi =  "Kızartmalık Patates";
            urun3.Fiyati = 12.7;

            Product[] Urunler = new Product[] {urun1,urun2,urun3};

            foreach (var Product in Urunler)
            {
                Console.WriteLine(Product.UrununAdi+" "+Product.Aciklamasi + " "+Product.Fiyati +" "+ "<-------------------------------------");
            }

            Console.WriteLine("--------Property--------");

            // İnstance - Örnek 
            // Encapsulation - Kapsülleme 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Armut yeşil", 12 , 10);
            sepetManager.Ekle2("Elma", "Elma yeşil", 12 , 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12 , 8);




        }
    }
}

// Dont Repeat Your Self - DRY - Clean Code - Best Practice
