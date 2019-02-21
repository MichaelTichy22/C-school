using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv01._1
{
    class Program
    {
        class Address
        {
            public string street;
            public string number;
            public string city;
            public string postcode;
        }
        class Person
        {
            public string firstName;
            public string lastName;
            public Address address;
        }
        static void Main(string[] args)
        {
            //Příklad 1
            Person person = new Person();
            person.firstName = "Josef";
            person.lastName = "Novák";
            Address address = new Address();
            address.city = "Praha 1";
            address.street = "Jindřišská 16";
            address.number = "16";
            address.postcode = "111 50";
            person.address = address;
            Console.WriteLine(
                    person.firstName + " " + person.lastName + "\n" +
                    person.address.street + " " + person.address.number + "\n" +
                    person.address.postcode + ", " + person.address.city
                );
        }
    }
}
