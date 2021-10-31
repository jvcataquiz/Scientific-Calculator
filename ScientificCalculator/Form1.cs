using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button28_Click(object sender, EventArgs e)
        {

        }


        private void equalbtn_Click(object sender, EventArgs e)
        {

        }

        private void decibtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + ".";
        }
        private void btnzero_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {

        }
        private void btn5_Click(object sender, EventArgs e)
        {

        }
        private void btn6_Click(object sender, EventArgs e)
        {

        }
        private void btn7_Click(object sender, EventArgs e)
        {

        }
        private void btn8_Click(object sender, EventArgs e)
        {

        }
        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}
