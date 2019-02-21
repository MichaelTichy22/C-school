using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            int userNumber;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Zadejte číslo hledané číslo: ");
                
                if (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.WriteLine("není číslo!");
                    i--;
                    continue;
                }

                if (userNumber == number)
                {
                    Console.WriteLine("Výhra!");
                    break;
                }
                else
                {
                    if (number < userNumber)
                    {
                        Console.WriteLine("Špatně! Hledané číslo je menší!");
                    }
                    else
                    {
                        Console.WriteLine("Špatně! Hledané číslo je větší!");
                    }
                    if (i == 9)
                    {
                        Console.WriteLine("Prohra!");
                    }
                }
            }
        }
    }
}
