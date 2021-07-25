using System;

namespace Odev_2.Gun
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Gomlek = new Product();
            Gomlek.Cesitleri = "Gri-Truncu-Mavi-Yeşil-Beyaz";
            Gomlek.OrtFiyat = 30;
            Gomlek.Tür = "Yazlık-Kışlık";
            Gomlek.ÜrünKodu = "#44F585";
            Gomlek.UrunIsmi = "Gomlek";

            Product Ceket = new Product();
            Ceket.Cesitleri = "Mor-Truncu-Kahverengi-Gri";
            Ceket.OrtFiyat = 45;
            Ceket.Tür = "Kışlık";
            Ceket.ÜrünKodu = "#F0LMN1";
            Ceket.UrunIsmi = "Ceket";

            Product Kazak = new Product();
            Kazak.Cesitleri = "Mor-Pembe-Lila-Mürdüm";
            Kazak.OrtFiyat = 60;
            Kazak.Tür = "Kışlık";
            Kazak.ÜrünKodu = "#11K00L";
            Kazak.UrunIsmi = "Kazak";



            // Console.WriteLine(Gomlek.Cesitleri + " " + Gomlek.OrtFiyat + " " + Gomlek.Tür + " " +  Gomlek.ÜrünKodu);
            // Console.WriteLine(Ceket.Cesitleri + " " + Ceket.OrtFiyat + " " + Ceket.Tür + " " + Ceket.ÜrünKodu);


            Product[] Urunler = new Product[] {Gomlek,Ceket,Kazak};


           foreach (var Product in Urunler)
            {
              Console.WriteLine(Product.UrunIsmi + " <= " + Product.Cesitleri+ " " + Product.OrtFiyat + " " + Product.Tür + " " + Product.ÜrünKodu);
            }
        }

        
    }

    class Product
    {
        public string Gomlek { get; set; }

        public string Ceket { get; set; }

        public string Kazak { get; set; }

        public string Cesitleri { get; set; }

        public string Tür{ get; set; }

        public string ÜrünKodu { get; set; }

        public int OrtFiyat { get; set; }

        public string UrunIsmi { get; set; }
    }

}
