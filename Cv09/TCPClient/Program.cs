using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("12.0.0.1"), 1200);
            try
            {
                socket.Connect(endPoint);
                Console.WriteLine($"TCP Client listen  with TCP server {endPoint.ToString()}");
                while (true)
                {
                    Console.Write("> ");
                    string message = Console.ReadLine();
                    byte[] data = Encoding.Default.GetBytes(message);
                    socket.Send(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"TCP client could not be connected to {endPoint.ToString()}. ({e.Message})");
            }
            
        }
    }
}
