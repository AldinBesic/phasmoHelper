using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace BBI_PhasmoHelperV1
{
    /// <summary>
    /// The Command class is responsible for sending commands to the server.
    /// </summary>
    class Command
    {
        private Server server;

        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        /// <param name="server">The server to which commands will be sent.</param>
        public Command(Server server)
        {
            if (server == null)
            {
                throw new ArgumentNullException("server");
            }
            this.server = server;
        }

        /// <summary>
        /// Sends a command to the server.
        /// </summary>
        /// <param name="commandType">The type of command to send. This should be a single byte.</param>
        /// <param name="data">The data to send with the command. This should be a string of no more than 128 characters.</param>
        /// <exception cref="ArgumentException">Thrown when the data length exceeds 128 characters.</exception>
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

            NetworkStream stream = server.TcpClient.GetStream();
            stream.Write(packetData, 0, packetData.Length);
        }
    }
}
