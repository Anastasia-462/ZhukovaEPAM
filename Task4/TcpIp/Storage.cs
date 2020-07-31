using System.Collections.Generic;

namespace TcpIp
{
    /// <summary>
    /// Class to storage all message from client.
    /// </summary>
    public class Storage
    {
        List<string> storage;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Storage()
        {
            storage = new List<string>();
        }

        /// <summary>
        /// Method to add new message.
        /// </summary>
        /// <param name="ip">Server address.</param>
        /// <param name="message">Message from client.</param>
        public void AddMessage(string ip, string message)
        {
            storage.Add(ip + "/" + message);
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A line with all client messages.</returns>
        public override string ToString()
        {
            string result = "";
            foreach (string message in storage)
                result += message + "\n";
            return result;
        }
    }
}
