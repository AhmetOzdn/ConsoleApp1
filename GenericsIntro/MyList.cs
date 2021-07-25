using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>// Ben MYListimde T ile çalışıcam demektir Elemanın türünü T belirler 
    {
        T[] items; // direkt Class içine yazmamızın sebebi heryerden diziye erişmektir

        //Constructor-Yapıcı "ctor" tabx2 yazınca alttaki ilk class gelir  bir Class new lendiğinde çalışan bloğa denir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // GeçiciDizi=tempArray   bizim yerimize items daki yeni eleman eklenince eskisi kaybolmaması için buna emanet ediyoruz
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // burada demek istenilen geçici dizideki elemanları geri almaktır
            }
                items[items.Length - 1] = item; // burada son elemandan bir önceki yere eklenmek istenen elemanı ekleyeceğimiz yeri verir  
        }
    }
}
