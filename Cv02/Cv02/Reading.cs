using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei.BaseLib
{
    public class Reading
    {
        /// <summary>
        /// Reads input from console and return the written value
        /// </summary>
        /// <returns>int</returns>
        public static int ReadInt()
        {
            int input;
            bool isInt;
            do
            {
                Console.Write("Napište int: ");
                isInt = int.TryParse(Console.ReadLine(), out input);
            } while (!isInt);

            return input;
        }

        /// <summary>
        /// Reads input from console and return the written value
        /// </summary>
        /// <returns>int</returns>
        public static double ReadDouble()
        {
            double input;
            bool isDouble;
            do
            {
                Console.Write("Napište double: ");
                isDouble = double.TryParse(Console.ReadLine(), out input);
            } while (!isDouble);

            return input;
        }

        /// <summary>
        /// Reads input from console and return the written value
        /// </summary>
        /// <returns>int</returns>
        public static char ReadChar()
        {
            char input;
            bool isChar;
            do
            {
                Console.Write("Napište char: ");
                isChar = char.TryParse(Console.ReadLine(), out input);
            } while (!isChar);

            return input;
        }

        /// <summary>
        /// Reads input from console and return the written value
        /// </summary>
        /// <returns>int</returns>
        public static string ReadString()
        {
            string input;

            Console.Write("Napište string: ");
            input = Console.ReadLine();

            return input;
        }
    }
}
