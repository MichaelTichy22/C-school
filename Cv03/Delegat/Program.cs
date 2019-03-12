using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Program
    {
        public static Students CreateArrayOfStudents(Students students)
        {
            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Reading.ReadInt();
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] array = null;
            bool end = false;
            do
            {
                Console.WriteLine("1. Načtení studentů z klávesnicee");
                Console.WriteLine("2. Výpis studentů na obrazovku");
                Console.WriteLine("3. Seřazení studentů podle čísla");
                Console.WriteLine("4. Seřazení studentů podle jména");
                Console.WriteLine("5. Seřazení studentů podle fakulty");
                Console.WriteLine("7. Konec programu");

                Console.Write("Vaše volba: ");
                string volba = Console.ReadLine();
                Console.Clear();

                switch (volba)
                {
                    case "1":
                        array = CreateArray();
                        break;
                    case "0":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Neznámý příkaz");
                        break;
                }
                Console.WriteLine("<stiskněte libovolnou klávesu pro pokračování>");
                if (!end)
                {
                    Console.ReadKey();
                }

                Console.Clear();
            } while (!end);
        }
    }
}
