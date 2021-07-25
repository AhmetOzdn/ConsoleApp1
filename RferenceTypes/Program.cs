using System;

namespace ReferenceTypes
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // int,decimal,float,enum,boolean => ValueTypes-DeğerTipler'dir
            int   sayi1 = 10;
            int   sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            //Console.WriteLine("Sayı 1 : "+sayi1);

            //arrays,class,interface... => ReferenceTypes-ReferansTipler'dir
            int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            int[] sayilar2 = new int[] { 10, 20, 30, 40 };
            sayilar1 = sayilar2;
            sayilar2[0] = 100;
            //Console.WriteLine("Sayılar-1 : "+sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Rengin";           
            person1 = person2;
            person1.FirstName = "Engin" ;
            //Console.WriteLine(person2.FirstName);




            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCartNumber = "234567890";
            Employee employee = new Employee();
            employee.FirstName = "Murat";

            Person person3 = customer;
            person3.FirstName = "Mehmet";
            //Console.WriteLine(customer.FirstName);
            // boxing (((Customer)person3).CreditCartNumber) gibi 
            //Console.WriteLine(((Customer)person3).CreditCartNumber);// person3 üzerinden CreditCartNumber'a bu  şekilde ulaşabiliriz

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); // burada bizden sadece person istemsine ramen hepsini girebildik bunun sebebi person'un "Base Class" olmasıdır
            personManager.Add(customer);
            personManager.Add(person2);



        }
    }

    class Person // = Kişi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //Base Class - Person
    class Customer: Person // = Müşteri ve ":" işaretle demek istediğimiz artık customer'ın içerisinde person'un içi+CreditCartNumber'ın içi var demektir 
    {
        public string CreditCartNumber { get; set; }
    }

    //Base Class - Person
    class Employee : Person // = Personel ve ":" işaretle demek istediğimiz artık customer'ın içerisinde person'un içi+EmployeeNumber'ın içi  var demektir 
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
