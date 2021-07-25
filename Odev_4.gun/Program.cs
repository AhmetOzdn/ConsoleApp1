using System;
using System.Collections.Generic;

namespace Odev_4.gun
{
    class Program   
    {
        static void Main(string[] args)
        {
            // Hazır Dictionary
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(52,"Murat");


            Console.WriteLine(Ogrenci.Count);
            Console.WriteLine(Ogrenci.Count);
            Console.WriteLine(Ogrenci.Count);

            // Kendi Yaptığımız Dictionary 
            MyDictionary<int, string> Ogrenci1 = new MyDictionary<int, string>();
            Ogrenci1.Add(703,"Efe");
            
            Console.WriteLine(Ogrenci1.Count);
            Console.WriteLine(Ogrenci1.Count);
            Console.WriteLine(Ogrenci1.Count);
            Console.WriteLine(Ogrenci1.Count);
            Console.WriteLine(Ogrenci1.Count);
        }
    }

    class MyDictionary<T, B>
    {
        T[] arrayT;
        B[] arrayB;
        T[] TempArrayT;
        B[] TempArrayB;

        public MyDictionary()
        {
            arrayT = new T[0];
            arrayB = new B[0];
        }
        public void Add(T item, B value)
        {
            TempArrayT = arrayT;
            TempArrayB = arrayB;

            arrayT = new T[arrayT.Length + 1];
            arrayB = new B[arrayB.Length + 1];

            for (int i = 0; i < TempArrayT.Length; i++)
            {
                arrayT[i] = TempArrayT[i];
                arrayB[i] = TempArrayB[i];
            }

            arrayT[arrayT.Length - 1] = item;
            arrayB[arrayB.Length - 1] = value;

            for (int i = 0; i < TempArrayT.Length; i++)
            {
                Console.WriteLine(arrayT[i]);
                Console.WriteLine(arrayB[i]);
            }
        }



        public int Count
        {
            get { return arrayB.Length; }

        }

    }
}
