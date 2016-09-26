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

namespace MyClass
{
    public class MyFunctions
    {
        public TextWriter tw { get; set; }
        public TextReader tr { get; set; }
        public Socket s { get; set; }
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
        public void Connect(SettingsClass settings)
        {
            try
            {
                s = new Socket(AddressFamily.InterNetwork,
                                SocketType.Stream,
                                ProtocolType.Tcp);
                if (!s.Connected)
                {

                    IPEndPoint iep = new IPEndPoint(IPAddress.Parse(settings.ServerIP), settings.ServerPort);
                    s.Connect(iep);
                    NetworkStream nws = new NetworkStream(s);
                    tw = new StreamWriter(nws);
                    tr = new StreamReader(nws);
                    var instance = new frmClient();
                    Thread th = new Thread(instance.ResponseListner);
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }      
        public void Disconnect()
        {
            if (s.Connected)
                s.Close();
        }
    }
}
