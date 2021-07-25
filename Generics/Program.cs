using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sehirler = new List<string>();
            Sehirler.Add("Ankara");
            Sehirler.Add("Ankara");
            Sehirler.Add("Ankara");
            Sehirler.Add("Ankara");
            Sehirler.Add("Ankara");
            Sehirler.Add("Ankara");
            Console.WriteLine(Sehirler.Count);

            MyList<string> Sehirler2 = new MyList<string>();
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Sehirler2.Add("Erzurum");
            Console.WriteLine(Sehirler2.Count);






        }   
    }

    class MyList<T> // Generic Class
    {
        T[] array;
        T[] temparray;

        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item) 
        {
            temparray = array;
            array = new T[array.Length + 1];

            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];
            }
        }

       

        public int Count
        {
            get { return array.Length; }
         
        }



    }
}
