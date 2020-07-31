using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TcpIp;

namespace TcpIpTest
{
    [TestClass]
    public class TCP_IP_Test
    {
        /// <summary>
        /// Test for verifitation translater from Russian to English. 
        /// </summary>
        [TestMethod]
        public void TestParser_FromRussianToEnglish()
        {
            Server server = new Server("127.0.0.1", 904);
            Client client = new Client("127.0.0.1", 904);

            client.Translaters += delegate (string mes)
            {
                Parser parser = new Parser();
                return parser.Parsing(mes);
            };
            Task.Run(() => { server.SendMessage("привет"); });

            Assert.AreEqual("privet ", client.GetMessage());
        }

        /// <summary>
        /// Test for verifitation translater from English to Russian. 
        /// </summary>
        [TestMethod]
        public void TestParser_FromEnglishToRussian()
        {
            Server server = new Server("127.0.0.1", 904);
            Client client = new Client("127.0.0.1", 904);

            client.Translaters += delegate (string mes)
            {
                Parser parser = new Parser();
                return parser.Parsing(mes);
            };
            Task.Run(() => { server.SendMessage("mirotvorec"); });

            Assert.AreEqual("миротворец ", client.GetMessage());
        }

        /// <summary>
        /// Test to checking message storage.
        /// </summary>
        [TestMethod]
        public void TestStorage_MessageFromClient()
        {
            Server server = new Server("127.0.0.1", 904);
            Client client = new Client("127.0.0.1", 904);
            Storage storage = new Storage();
            server.MesList += messages =>
            {
                storage.AddMessage("127.0.0.1", messages);
            };

            Task.Run(() =>
            {
                client.SendMessage("mirotvorec");
                client.SendMessage("мир");
                client.SendMessage("привет");
            });
            server.GetMessage();
            server.GetMessage();
            server.GetMessage();
            Assert.AreEqual("127.0.0.1/mirotvorec\n" + "127.0.0.1/мир\n" + "127.0.0.1/привет\n", storage.ToString());
        }

        /// <summary>
        /// Test to verify sending a message from client to server.
        /// </summary>
        [TestMethod]
        public void TestSendMessage_FromClietnToServer()
        {
            Server server = new Server("127.0.0.1", 904);
            Task.Run(() => { server.GetMessage(); });
            Client client = new Client("127.0.0.1", 904);
            client.SendMessage("мир во всем мире");
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Test to verify sending a message from server to client.
        /// </summary>
        [TestMethod]
        public void TestSendMessage_FromServerToClient()
        {
            Server server = new Server("127.0.0.1", 904);
            Client client = new Client("127.0.0.1", 904);
            client.Translaters += delegate (string mes)
            {
                Parser parser = new Parser();
                return parser.Parsing(mes);
            };

            Task.Run(() => { server.SendMessage("мир"); });

            client.GetMessage();
            Assert.IsTrue(true);
        }
    }
}
