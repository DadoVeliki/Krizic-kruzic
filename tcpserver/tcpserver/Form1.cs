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
namespace tcpserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "127.0.0.1";
            textBox1.Text = "50000";
        }
        TcpListener server = null;
        TcpClient client = null;
        NetworkStream stream=null;
        Byte[] bytes = new Byte[256];
        String data = null;
        string zaPoruke = "";
        public void funkcija()
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Int32 port = Int32.Parse(textBox1.Text);
                IPAddress localAddr = IPAddress.Parse(textBox2.Text);

                server = new TcpListener(localAddr, port);
                server.Start();


                /*poruke.AppendText("Waiting for a connection... ");
                Thread thr1 = new Thread(funkcija);
                thr1.Start();
                thr1.Join();
                //poruke.AppendText("Connected!");
               */
                int brojac = 0;
                poruke.AppendText("Waiting for a connection... ");
                while (brojac<1000000)
                {
                    //zaPoruke="Waiting for a connection... ";
                    

                    client = server.AcceptTcpClient();
                    poruke.AppendText("Connected!");

                    data = null;

                    stream = client.GetStream();


                    brojac++;
                }
                

                client.Close();
            }
            catch
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;

            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                poruke.AppendText("Received: " + data);

                data = data.ToUpper();

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                stream.Write(msg, 0, msg.Length);
                poruke.AppendText("Sent: " + data);
            }
        }
    }
}
