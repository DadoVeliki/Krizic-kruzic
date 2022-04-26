using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace tcpclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "127.0.0.1";
            textBox1.Text = "50000";
        }
        /*
        string server;
        string message;*/
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void funkcija()
        {
            try
            {
                Int32 port = Int32.Parse(textBox1.Text);
                TcpClient client = new TcpClient("127.0.0.1", port);
                poruke.AppendText("Povezano sa serverom");
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(upis.Text.ToString());

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                poruke.AppendText("Sent: " + upis.Text.ToString());

                data = new Byte[256];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                poruke.AppendText("Received: " + responseData);

                stream.Close();
                client.Close();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread nit = new Thread(funkcija);
            nit.Start();
            nit.Join();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
