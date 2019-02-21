using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv01
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
    class Program
    {
        const uint DEFAULT_COUNT = 100;

        static uint GetCount(string[] args)
        {
            if (args.Length == 0)
                return DEFAULT_COUNT;
            uint temp;
            if (uint.TryParse(args[0], out temp))
                return temp;
            return DEFAULT_COUNT;

        }

        static void Main(string[] args)
        {
            uint count = GetCount(args);

            //string greeting = "Hello world";

            //for (int i = 0; i < count; i++)
            //{
            //    greeting += " again";
            //}
            //greeting += "!";
            //Console.WriteLine(greeting);

            //if (count != 0)
            //{
            //    StringBuilder greetingBuilder = new StringBuilder();
            //    greetingBuilder.Append("Hello world again");
            //    for (int i = 0; i < count; i++)
            //    {
            //        greetingBuilder.Append(" again");
            //    }
            //    greetingBuilder.Append("!");
            //    Console.WriteLine(greetingBuilder.ToString());
            //}
        }
    }
}
