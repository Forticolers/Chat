using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClientMT
{
    [Serializable]
    public class SettingsClass
    {
        [XmlElement()]
        public string Username { get; set; }
        [XmlElement("Private Message")]
        public bool PrivateMessage { get; set; }
        [XmlElement("Broadcast Message")]
        public bool BroadcastMessage { get; set; }
        //[XmlElement()]
        //public Dictionary<string,int> listServerAndPort { get; set; }
        [XmlElement("Server port")]
        public int ServerPort { get; set; }
        [XmlElement("Server IP")]
        public string ServerIP { get; set; }
    }
}
