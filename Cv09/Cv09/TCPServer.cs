using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Cv09
{
    public class TCPServer
    {
        public const string DefaultIpAddress = "127.0.0.1";
        public const int DefautlPort = 1200;
        private const int ListenerCount = 1;

        private IMessageProcessor processor;

        public TCPServer(IMessageProcessor processor, string ipAddress, int port)
        {
            this.processor = processor;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            processor?.Process($"TCP server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);

            socket.Listen(ListenerCount);

            Socket acceptedSocket = socket.Accept();
            Byte[] acceptedData = new byte[acceptedSocket.SendBufferSize];
            while (true) {
                int bufferCount = acceptedSocket.Receive(acceptedData);
                byte[] data = new byte[bufferCount];
                for (int i = 0; i < bufferCount; i++)
                {
                    data[i] = acceptedData[i];
                }

                string message = Encoding.Default.GetString(data);

                processor?.Process(message);

                if (message == "exit")
                {
                    break;
                }
            }
            
        }


    }
}
