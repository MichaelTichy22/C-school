using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Příklad 2
            
            for (int i = 97; i < 123; i++) {
                Console.WriteLine((char)(i));
            }

            int index = 97;
            while (index < 123) {
                Console.WriteLine((char)(index));
                index++;
            }

            index = 97;
            do {
                Console.WriteLine((char)(index));
                index++;
            } while (index < 123);
        }
    }
}
