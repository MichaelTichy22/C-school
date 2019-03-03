using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fei.BaseLib;

namespace Cv02._2
{
    class Program
    {
        public static int[] CreateArray()
        {
            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Reading.ReadInt();
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static void FindMinNumber(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Nejmenší číslo v poli je "+ min);
        }

        public static void FindNumberFirst(int[] array)
        {
            Console.Write("Najdi číslo");
            int numberToFind = Reading.ReadInt();

            for (int i = 0; i < array.Length; i++)
            {
                if (numberToFind == array[i])
                {
                    Console.WriteLine("První výskyt čísla "+numberToFind+ " je na pozici "+i);
                    return;
                }
            }
            Console.WriteLine("Číslo " + numberToFind + " nenalezeno!");
        }

        public static void FindNumberLast(int[] array)
        {
            Console.Write("Najdi číslo");
            int numberToFind = Reading.ReadInt();
            int position = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (numberToFind == array[i])
                {
                    position = i;
                }
            }
            if (position == -1)
            {
                Console.WriteLine("Číslo " + numberToFind + " nenalezeno!");
            }
            else {
                Console.WriteLine("Poslední výskyt čísla " + numberToFind + " je na pozici " + position);
            }
            
        }

        static void Main(string[] args)
        {
            //int inputInt = Reading.ReadInt();
            //Console.WriteLine(inputInt);

            //double inputDouble = Reading.ReadDouble();
            //Console.WriteLine(inputDouble);

            //char inputChar = Reading.ReadChar();
            //Console.WriteLine(inputChar);

            //string inputString = Reading.ReadString();
            //Console.WriteLine(inputString);

            int[] array = null;
            bool end = false;
            do
            {
                Console.WriteLine("1. Zadaní prvků pole z klávesnice");
                Console.WriteLine("2. Výpis pole na obrazovku");
                Console.WriteLine("3. Utřídění pole vzestupně");
                Console.WriteLine("4. Hledání minimálního prvku");
                Console.WriteLine("5. Hledání prvního výskytu zadaného čísla");
                Console.WriteLine("6. Hledání posledního výskytu zadaného čísla");
                Console.WriteLine("7. Konec programu");

                Console.Write("Vaše volba: ");
                string volba = Console.ReadLine();
                Console.Clear();

                switch (volba)
                {
                    case "1":
                        array = CreateArray();
                        break;
                    case "2":
                        if (array != null && array.Length != 0)
                        {
                            PrintArray(array);
                        }
                        break;
                    case "3":
                        if (array != null && array.Length != 0)
                        {
                            array = SortArray(array);
                            Console.WriteLine("Pole setříděno");
                        }
                        break;
                    case "4":
                        if (true)
                        {
                            FindMinNumber(array);
                        }
                        break;
                    case "5":
                        if (true)
                        {
                            FindNumberFirst(array);
                        }
                        break;
                    case "6":
                        if (true)
                        {
                            FindNumberLast(array);
                        }
                        break;
                    case "7":
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
