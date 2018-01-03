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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (metrBtn.Checked)
            {

                var c = int.Parse(metrBox.Text);
                var n = c * 3.28;
                footBox.Text = (n).ToString();
                metrBox.Text = string.Empty;


            }
            else if (footBtn.Checked)
            {

                var v = int.Parse(footBox.Text) * 0.3048;
                var mi = int.Parse(footBox.Text) * 0.00018939;
                metrBox.Text = v.ToString();
                milBox.Text = mi.ToString();
                footBox.Text = string.Empty;

            }
            else if (milBtn.Checked)
            {


                var f = int.Parse(milBox.Text) * 5280;
                var m = int.Parse(milBox.Text) * 1609.344;
                footBox.Text = f.ToString();
                metrBox.Text = m.ToString();
                milBox.Text = string.Empty;

            }
        }

        private void milBtn_CheckedChanged(object sender, EventArgs e)
        {
            milBox.Enabled = true;
            footBox.Enabled = false;
            metrBox.Enabled = false;
            footBox.Text = string.Empty;
            metrBox.Text = string.Empty;
        }

        private void metrBtn_CheckedChanged(object sender, EventArgs e)
        {
            metrBox.Enabled = true;
            footBox.Enabled = false;
            milBox.Enabled = false;
            footBox.Text = string.Empty;
            milBox.Text = string.Empty;

        }

        private void footBtn_CheckedChanged(object sender, EventArgs e)
        {
            footBox.Enabled = true;
            metrBox.Enabled = false;
            milBox.Enabled = false;
            milBox.Text = string.Empty;
            metrBox.Text = string.Empty;

        }

        private void findBtn_Click(object sender, EventArgs e)
        {

            var b = int.Parse(numb.Text);
            var c = Math.Pow(10, b - 1);
            var m = Math.Pow(10, b);
            numb2.Text += " polendrome numbers are : ";
            double i;


            for (i = c; i < m; i++)

            {

                char[] arr = i.ToString().ToCharArray();
                Array.Reverse(arr);
                var reversed = new string(arr);
                if (reversed == i.ToString())
                {

                    numb2.Text += " " + reversed;
                 
                }


            }




        }

        private void miladbtn_CheckedChanged(object sender, EventArgs e)
        {
            miladbox.Enabled = true;
            hicribox.Enabled = false;
            hicribox.Text = string.Empty;
        }

        private void hicribtn_CheckedChanged(object sender, EventArgs e)
        {
            hicribox.Enabled = true;
            miladbox.Enabled = false;
            miladbox.Text = string.Empty;
        }

        private void convert2btn_Click(object sender, EventArgs e)
        {
            if (miladbtn.Checked)
            {
                if (miladbox.Text.Length == 4)
                {
                    var h = (int.Parse(miladbox.Text) + 42) - 621;
                    hicribox.Text = h.ToString();
                }
                else
                {
                    hicribox.Text = "duzgun il daxil edin";
                  
                }
            }
            if (hicribtn.Checked)
            {
                if (hicribox.Text.Length == 4)
                {
                    var q = (int.Parse(hicribox.Text) - 43) + 622;
                    miladbox.Text = q.ToString();
                }
                else
                {
                    hicribox.Text = "duzgun il daxil edin";
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numb2.Text = string.Empty;
            numb.Text = string.Empty;
        }
    }
}

