using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BBI_PhasmoHelperV1
{
    class Server
    {
        public string Name { get; private set; }
        public TcpClient TcpClient { get; private set; }
        public IPEndPoint DestinationEndPoint { get; private set; }

        public Server(string destinationIP, int port, string name)
        {
            if (string.IsNullOrEmpty(destinationIP))
            {
                throw new ArgumentNullException("destinationIP");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            if (port <= 0)
            {
                throw new ArgumentOutOfRangeException("port");
            }

            Name = name;
            DestinationEndPoint = new IPEndPoint(IPAddress.Parse(destinationIP), port);
            TcpClient = new TcpClient();
        }

        public void Connect()
        {
            TcpClient.Connect(DestinationEndPoint);
        }

        public void SendCommand(byte commandType, string data)
        {
            if (data.Length > 128)
            {
                throw new ArgumentException("Data length cannot exceed 128 characters");
            }

            byte[] commandTypeBytes = new byte[] { commandType };
            byte[] dataBytes = Encoding.ASCII.GetBytes(data);
            byte[] packetData = new byte[commandTypeBytes.Length + dataBytes.Length];

            commandTypeBytes.CopyTo(packetData, 0);
            dataBytes.CopyTo(packetData, commandTypeBytes.Length);

            NetworkStream stream = TcpClient.GetStream();
            stream.Write(packetData, 0, packetData.Length);
        }

        public string ReceiveResponse()
        {
            NetworkStream stream = TcpClient.GetStream();
            byte[] responseBuffer = new byte[128];
            int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
            string responseData = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
            return responseData;
        }
    }
}
