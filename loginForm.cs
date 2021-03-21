using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Operations;

namespace Cs_AplikacjaKliencka
{
    public partial class loginForm : Form
    {
        private static string server = "127.0.0.1";
        private static Int32 port = 6666;
        public static TcpClient Client = new TcpClient(server, port);
        public static NetworkStream stream;

        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stream.Close();
            Client.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string name = clientName.Text;
            string password = passwordText.Text;

            string message = (name + " " + password);
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            try
            {
                NetworkStream stream = Client.GetStream();
                stream.Write(data, 0, data.Length);

                data = new Byte[256];
                String response = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                if (response == "1")
                {
                    MessageBox.Show("Logged in.");
                    loggedForm logged = new loggedForm();
                    this.Close();
                    logged.Show();
                }
                else if (response == "0")
                {
                    MessageBox.Show("Incorrect credentials.");
                }   
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show("ArgumentNullException: {0}", Convert.ToString(error));
            }
            catch (SocketException error)
            {
                MessageBox.Show("SocketException: {0}", Convert.ToString(error));
            }
        }
    }
}
