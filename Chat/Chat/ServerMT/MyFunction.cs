using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ServerMT
{
    public class MyFunctions
    {
        public TextWriter tw;
        public TextReader tr;
        public Socket ss;
        private int nbClients;
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        public MyFunctions()
        {
            ss = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
        }
        public void CreateServer()
        {
            if (!ss.Connected)
            {
                IPEndPoint iep = new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), 5746);
                ss.Bind(iep);
                ss.Listen(1);
            }
            Thread th3 = new Thread(CreateServerLoop);
           
        }
        public void CreateServerLoop()
        {
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
            Thread th2 = new Thread(Listner);
            th2.Start();
            
        }
        public void Listner()
        {
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

    }
}
