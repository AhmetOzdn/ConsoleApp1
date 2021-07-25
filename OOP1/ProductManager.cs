using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encasulation   void=git yap bitir  int=üstünde çalışmak gerekirse return ile kullanılır
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName+" Eklendi.");
        }
        public void Uptade(Product prouct) 
        {
            Console.WriteLine(prouct.ProductName+" Güncellendi.");
        }

    }
}
