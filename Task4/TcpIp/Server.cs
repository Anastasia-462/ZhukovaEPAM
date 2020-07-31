using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpIp
{
    /// <summary>
    /// Server class.
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Delegate to storage all client messages.
        /// </summary>
        /// <param name="message">Client message.</param>
        public delegate void MessageList(string message);

        /// <summary>
        /// Event to storage client messages.
        /// </summary>
        public event MessageList MesList;

        private TcpListener tcpServer;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="ip">Server address.</param>
        /// <param name="port">Server port.</param>
        public Server(string ip, int port)
        {
            tcpServer = new TcpListener(IPAddress.Parse(ip), port);
            tcpServer.Start();
        }

        /// <summary>
        /// Method to get message from client.
        /// </summary>
        /// <returns>Getting message.</returns>
        public string GetMessage()
        {
            TcpClient client = tcpServer.AcceptTcpClient();

            byte[] buffer = new byte[1024];
            StringBuilder messageBuilder = new StringBuilder();
            NetworkStream network = client.GetStream();

            do
            {
                int bytes = network.Read(buffer, 0, buffer.Length);
                messageBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
            }
            while (network.DataAvailable);

            string message = messageBuilder.ToString();
            MesList(message);

            network.Close();
            client.Close();
            return message;
        }

        /// <summary>
        /// Method to send message to server.
        /// </summary>
        /// <param name="message">Sending message.</param>
        public void SendMessage(string message)
        {
            TcpClient client = tcpServer.AcceptTcpClient();
            NetworkStream network = client.GetStream();

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            network.Write(buffer, 0, buffer.Length);

            network.Close();
            client.Close();
        }

        /// <summary>
        /// Method to close tcpServer.
        /// </summary>
        public void Close()
        {
            tcpServer.Stop();
        }
    }
}
