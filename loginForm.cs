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
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            string server = "127.0.0.1";
            Int32 port = 6666;
            string name = clientName.Text;
            string password = passwordText.Text;
            string message = (name + " " + password);
            Byte[] data = Encoding.ASCII.GetBytes(message);
            try
            {
                TcpClient Client = new TcpClient(server, port);
                NetworkStream stream = Client.GetStream();
                stream.Write(data, 0, data.Length);

                data = new Byte[256];
                String response = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                response = Encoding.ASCII.GetString(data, 0, bytes);

                if (response == "1")
                {
                    MessageBox.Show("Logged in.");
                    loggedForm logged = new loggedForm();
                    this.Close();
                    logged.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials.");
                }
                stream.Close();
                Client.Close();
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
