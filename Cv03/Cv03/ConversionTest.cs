using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv03
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int ID)
        {
            this.ID = ID;
        }

        public override string ToString()
        {
            return ID + Name;
        }

        public static implicit operator Person(int v)
        {
            return new Person(v);
        }

        public static implicit operator int(Person person)
        {
            return person.ID;
        }
    }


    static class ConversionTest
    { 
        public static void DoIt()
        {
            double realNumber = 3.14;
            realNumber = Math.PI;
            realNumber = 10;
            realNumber = 10.0;
            realNumber = (double)10;

            int integerNumber = 3;
            integerNumber = (int)Math.Round(Math.PI);

            Person person = new Person(1);
            Person person2 = integerNumber;
            int integerNumber2 = person2;


            Object perosn2 = new Person(2);
            (person as Person).Name = "Antonín";
            if (person2 is Person)
            {

            }

            if (person2.GetType() == typeof(Person))
            {

            }
        }
    }
}
