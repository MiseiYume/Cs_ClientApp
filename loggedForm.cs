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
using Cs_AplikacjaKliencka;

namespace Cs_AplikacjaKliencka
{
    public partial class loggedForm : Form
    {
        public Boolean InOutCash;
        public loggedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "127.0.0.1";
            Int32 port = 6666;
            int operation ;
            int cAmount;
            string message = (operation + " " + cAmount);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Close();
            login.Show();
        }

        private void cashinRadioB_CheckedChanged(object sender, EventArgs e)
        {
            InOutCash = false;
        }

        private void loggedForm_Load(object sender, EventArgs e)
        {

        }

        private void withdrawRadioB_CheckedChanged(object sender, EventArgs e)
        {
            InOutCash = true;
        }
    }
}
