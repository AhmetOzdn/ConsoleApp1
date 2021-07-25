using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_geliştirici_3.gun
{
    class SepetManager
        
    {
        // Naming Convention
        //Syntax
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.UrununAdi);

        }
        public void Ekle2(string UrunAdi, string aciklama , double fiyat , int StokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + UrunAdi);
        }
    }
}
