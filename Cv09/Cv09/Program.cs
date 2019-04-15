using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte[] message = Encoding.ASCII.GetBytes(args[0]);
            string ipAddress = TCPServer.DefaultIpAddress;
            int port = TCPServer.DefautlPort;
            bool showHelp = false;

            //if (args[0] == "-help")
            //{
            //    showHelp = true;
            //}
            //else
            //{
            //    ipAddress = args[0];
            //}

            //if (!Int32.TryParse(args[1], out port))
            //{
            //    Console.WriteLine("Port musí být číslo");
            //}

            //if (showHelp) return;

            StartTCPServer(ipAddress, port);

        }

        private static void StartTCPServer(string ipAddress, int port)
        {
            Console.WriteLine("Starting TCP server");

            TCPServer server = new TCPServer(new ConsoleMessageProcessor(), ipAddress, port);
        }
    }
}
