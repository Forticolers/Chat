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
    public partial class frmServer : Form
    {
        MyFunctions myFunc;
        public frmServer()
        {
            InitializeComponent();
            myFunc = new MyFunctions();
            myFunc.CreateServer();
        }
    }
}
