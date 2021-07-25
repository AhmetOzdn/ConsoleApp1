using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_geliştirici_3.gun
{
    class Product
    {
        // Property - Özellik
        public int Id { get; set; }
        public string UrununAdi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklamasi { get; set; }

        public int StokAdedi { get; set; }
    }
}
