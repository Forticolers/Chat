using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ClientConsole
{
    class Program
    {
        TextWriter tw;
        TextReader tr;
        Socket ss;
        public Program()
        {
            ss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("157.26.229.185"), 1234);
            ss.Connect(iep);
            NetworkStream nws = new NetworkStream(ss);
            tw = new StreamWriter(nws);
            tr = new StreamReader(nws);
            Thread th = new Thread(ResponseListner);
            th.Start();
            while (true)
            {
                string req = Console.ReadLine();
                tw.WriteLine(req);
                tw.Flush();
            }
        }

        private void ResponseListner()
        {
            while (true)
            {

                string rep = tr.ReadLine();
                Console.WriteLine(rep);
            }
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
