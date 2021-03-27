using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
