using System;

namespace Constructors // - YAPICI BLOK
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1 , FirstName = "Ahmet",LastName="Özden",City="Kocaeli"};
            Customer customer1 = new Customer(2,"Bora","Koca","Rize");


            Console.WriteLine(customer1.FirstName);
        }

    }

    class Customer
    {
        public Customer()
        {

        }

        //Constructor()= ctor = Default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
