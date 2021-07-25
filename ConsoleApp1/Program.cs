using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // type Safety - Tip Güvenliği
            // Do not Yourself - Kendini tekrarlama
            // Değer Tutucu - Takma isim - Alias
            String KategoriListesi = "Categories";
            int OgrenciSayisi = 3000 ;
            double FaizOranı = 1.15 ; // küsüratlı sayıları tutmada kullanılır "double"
            bool SistemeGirisYapmısMi = true;
            Console.WriteLine(KategoriListesi);
            double  DolarDun = 7.35;
            double DolarBugun = 7.35;

            if (DolarDun > DolarBugun) 
            {
                Console.WriteLine("Dolar Düşüşte");
            }
            else if (DolarDun < DolarBugun) 
            {
                Console.WriteLine("Dolar Yükselişte");
            }
            else
            {
                Console.WriteLine("Dolar Değeri Değişmedi");
            }

            if (SistemeGirisYapmısMi== true)
            {
                Console.WriteLine("Hosgeldiniz");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }
      

        }
    }
}
