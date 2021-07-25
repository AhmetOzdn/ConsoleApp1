using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array - Diziler
            String[] Kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Giriş İçin Temel Kurs", "Java","Phyton","C#" };

            for (int i = 0; i <Kurslar.Length; i++) // i=i+2 veya i+=2=> i yi 2 arttır demektir tek tek arttırmak için "i++ veya i+1" şeklinde yazmamız gerekir
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("Kurs Eklenicek - Footer");

            Console.WriteLine("For Bitti");
            foreach (string kurs in Kurslar) // buradaki kurs elemanları dolaşırken takma ad olarak kullanıyoruz
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
