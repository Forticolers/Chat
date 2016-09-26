using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClientMT
{
    public partial class Connection : Form
    {
        SettingsClass settings = new SettingsClass();
        public MyFunctions myFunc;
        public void LoadSettings()
        {
            if (File.Exists("Settings.xml"))
            {
                XmlSerializer s = new XmlSerializer(typeof(SettingsClass));

                StreamReader sr = new StreamReader("Settings.xml");

                settings = (SettingsClass)s.Deserialize(sr);

                sr.Close();
            }
        }
        public Connection()
        {
            InitializeComponent();
            LoadSettings();
            myFunc = new MyFunctions();
            this.lblCurrentServerInSettings.Text = $"The current server in your settings is : {settings.ServerIP} : {settings.ServerPort}";
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (!myFunc.s.Connected)
            {
                myFunc.Connect(settings);
                btnConnectDisconnect.Text = "Disconnect";
            }
            else
            {
                
                btnConnectDisconnect.Text = "Connect";
            }       


}       
    }
}
