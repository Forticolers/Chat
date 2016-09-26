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

namespace ClientMT
{
    public partial class frmClient : Form
    {
        #region Vars
        const int VERSION = 1;
        const string DEVLOPPER = "Julien Jeanbourquin";
        public Settings settings = new Settings();
        public Connection connection = new Connection();
        public MyFunctions myFunc;
        #endregion
        public frmClient()
        {
            InitializeComponent();
            myFunc = new MyFunctions();
            if (!File.Exists("Settings.xml") && MessageBox.Show("'Settings.xml' doesn't exist! Do you want do complete the settings right now ?\nYou will not be able to connect a server if you doesn't complete this!", "Missings something...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                settings.ShowDialog();
            }
        }

        private void MainMenuCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"This application has been created by {DEVLOPPER}.\nCurrent version is v.{VERSION}.");
        }

        private void MainMenuSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void MainMenuConnection_Click(object sender, EventArgs e)
        {
            connection.ShowDialog();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            new frmClient();
        }

        public void ResponseListner()
        {
            MessageBox.Show("enable");
            while (true)
            {
                try
                {
                    string rep = myFunc.tr.ReadLine();
                    Invoke(new Action<string>(Afficher), rep);
                }
                catch (Exception listningException)
                {
                    MessageBox.Show(listningException.ToString());
                }
                
            }
        }
        public void Afficher(string rep)
        {
            lsbListMessage.Items.Add(rep);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            myFunc.sendMessage(tbxMessage.Text);
        }
    }
}

