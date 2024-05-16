using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
    }
}
