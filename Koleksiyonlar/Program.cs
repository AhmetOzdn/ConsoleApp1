using System;
using System.Collections.Generic; // bunu nasıl ekledik derseiz alt tarafa list yazdık çıkan ampulden "using System.Collections.Generic;" i seçtik  ve buraya geldi

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet", "Murat", "Seyit", "Cemil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Mustafa";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> {"Ahmet", "Murat", "Seyit", "Cemil" }; // şeklinde liste elemanlarını kullanırız ve array yerine genellikle "List" kullanırız bunu kullanmamızın sebebi yeni eleman eklediğimizde listenin otomatik olarak kendini güncelleyip genişleyebilmesidir
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
