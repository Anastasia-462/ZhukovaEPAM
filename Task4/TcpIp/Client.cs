using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpIp
{
    /// <summary>
    /// Client class.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Delegate to translate message.
        /// </summary>
        /// <param name="message">Translating message.</param>
        /// <returns>Translated message.</returns>
        public delegate string Translater(string message);

        /// <summary>
        /// Event to translate message.
        /// </summary>
        public event Translater Translaters;

        private TcpClient tcpClient;
        private string ip;
        private int port;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="ip">Server address.</param>
        /// <param name="port">Server port.</param>
        public Client(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        /// <summary>
        /// Method to get message from server.
        /// </summary>
        /// <returns>Getting message.</returns>
        public string GetMessage()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(ip, port);

            byte[] buffer = new byte[1024];
            StringBuilder messageBuild = new StringBuilder();
            NetworkStream network = tcpClient.GetStream();

            do
            {
                int bytes = network.Read(buffer, 0, buffer.Length);
                messageBuild.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
            }
            while (network.DataAvailable);

            string message = messageBuild.ToString();
            message = Translaters(message);

            network.Close();
            tcpClient.Close();
            return message;
        }

        /// <summary>
        /// Method to send message to server.
        /// </summary>
        /// <param name="message">Sending message.</param>
        public void SendMessage(string message)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(ip, port);

            NetworkStream network = tcpClient.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            network.Write(buffer, 0, buffer.Length);
            network.Close();
            tcpClient.Close();
        }
    }
}
