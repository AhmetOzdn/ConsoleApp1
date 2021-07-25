using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ahmet Özden
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MüsteriNo = "12345";
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Özden";
            musteri1.TcNo = "1234567890";
            musteri1.Id = 1;

            // CivilHolding
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MüsteriNo = "54321";
            musteri2.SirketAdi = "CivilHolding";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
