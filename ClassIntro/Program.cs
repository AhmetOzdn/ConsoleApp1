using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adı = "Ahmet";
            int yas = 17;

            Kurs Kurs1 = new Kurs() ;
            Kurs1.KursAdi = "C#" ;
            Kurs1.Egitmen = "Engin Demirog" ;
            Kurs1.IzlenmeOrani = 68 ;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Kerem Engin";
            Kurs2.IzlenmeOrani = 70;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Phyton";
            Kurs3.Egitmen = "Berkay Demir";
            Kurs3.IzlenmeOrani = 80;

            //  Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen + "  İzlenme Oranı => " + Kurs1.IzlenmeOrani);

            Kurs[] Kurslar = new Kurs[] {Kurs1,Kurs2,Kurs3};

            foreach (var Kurs in Kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.Egitmen + " : " + Kurs.IzlenmeOrani);

            }
        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani { get; set; }
    } 
}
