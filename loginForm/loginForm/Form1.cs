using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int n = 1;
        string username;
        string password;

        private void button1_Click(object sender, EventArgs e)
        {
            username = loginBox.Text;
            password = passwordBox.Text;
           

            if (username.ToUpper() == "SANTA" || password == "Claus")
            {

                this.Hide();
                Form2 formm = new Form2();
                formm.Show();
                Console.ReadLine();
}
            else
            {
                MessageBox.Show(n + " attempts out of 3");
                n++;
            }

            if(n==4)
                {
                MessageBox.Show("you are blocked");
                this.Close();

            }
        }


           

        
    }
}


