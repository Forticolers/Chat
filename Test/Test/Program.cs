using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Test
{
    class Program
    {
        TextWriter tw;
        TextReader tr;
        Socket ss;
        int nbClients;
        public Program()
        {
            ss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("157.26.229.185"), 1234);
            ss.Bind(iep);
            ss.Listen(1);
            while (true)
            {
                Socket s = ss.Accept();
                ++nbClients;
                ClientCommunication cc = new ClientCommunication(s, nbClients);
                Thread th = new Thread(Communication);
                th.Start(cc);
            }
        }
        public void Communication(object o)
        {
            ClientCommunication cc = (ClientCommunication)o;
            NetworkStream nws = new NetworkStream(cc.socket);
            tw = new StreamWriter(nws);
            tr = new StreamReader(nws);
            tw.WriteLine("You are client number "+ cc.numero);
            tw.Flush();
            while (true)
            {
                string req = tr.ReadLine();
                tw.WriteLine("Response to " + req);
                tw.Flush();
            }

        }
        class ClientCommunication
        {
            public Socket socket { get; set; }
            public int numero { get; set; }
            public ClientCommunication(Socket s, int num)
            {
                this.socket = s;
                this.numero = num;
            }
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
