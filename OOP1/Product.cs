using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Snippet - Hazır kodlar  Product=Ürün    UniPrice=ÜrünFiyatı  unitsinStocks=ürünstoğu
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UniPrice { get; set; }
        public int UnitsInStocks { get; set; }
        
        

    }
}
