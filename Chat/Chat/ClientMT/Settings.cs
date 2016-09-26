using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ClientMT
{   
    public partial class Settings : Form
    {
        SettingsClass settings = new SettingsClass();
        public Settings()
        {
            InitializeComponent();
            this.lblCurrentIP.Text += MyFunctions.GetLocalIPAddress();
            LoadSettings();
        }  

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Save()
        {
            #region ApplyChange
            try
            {
                settings.Username = this.tbxUsername.Text;
                settings.PrivateMessage = this.cbxPrivateMessage.Checked;
                settings.BroadcastMessage = this.cbxBroadcastMessage.Checked;
                settings.ServerIP = tbxServerIP.Text;
                settings.ServerPort = Int32.Parse(tbxPort.Text);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show($"The value of the port is incorrect, please use numbers !");
            }
            
            #endregion
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsClass));

                StreamWriter writer = new StreamWriter("Settings.xml", false);
                serializer.Serialize(writer, settings);
                writer.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        public void LoadSettings()
        {
            if (File.Exists("Settings.xml"))
            {
                XmlSerializer s = new XmlSerializer(typeof(SettingsClass));

                StreamReader sr = new StreamReader("Settings.xml");

                settings = (SettingsClass)s.Deserialize(sr);

                sr.Close();
                
                #region settingToLoad
                this.tbxUsername.Text = settings.Username;
                this.cbxPrivateMessage.Checked = settings.PrivateMessage;
                this.cbxBroadcastMessage.Checked = settings.BroadcastMessage;
                this.tbxServerIP.Text = settings.ServerIP;
                this.tbxPort.Text = settings.ServerPort.ToString();
                #endregion
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoadSettings();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
