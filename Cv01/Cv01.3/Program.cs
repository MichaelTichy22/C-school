using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv01._3
{
    class Program
    {
        static string GetGender(string id)
        {
            int month = int.Parse(id.Substring(2, 2));
            if (month - 50 > 0)
            {
                return "Žena";
            }
            else
            {
                return "Muž";
            }
        }

        static void Main(string[] args)
        {
            string id = "906212/1234";

            Console.WriteLine(GetGender(id));
        }

    }
}
