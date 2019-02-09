using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(tbxRemoteHost.Text, 8080);
            Byte[] sendData = Encoding.ASCII.GetBytes(tbxUsername.Text+": "+tbxMessage.Text);
            udpClient.Send(sendData, sendData.Length);
        }
    }
}
