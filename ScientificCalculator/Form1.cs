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
        public void clearzer0()
        {
            if (txtboxdisplay.Text =="0")
            {
                txtboxdisplay.Clear();
            }
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
        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Clear();
            txtboxdisplay.Text = "0";
        }

        private void decibtn_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + ".";
        }
        private void btnzero_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "9";
        }

        private void cebtn_Click(object sender, EventArgs e)
        {
            
            if (txtboxdisplay.Text.Length == 1)
            {
                txtboxdisplay.Text = "0";
            }
            else
            {
                txtboxdisplay.Text = txtboxdisplay.Text.Substring(0, txtboxdisplay.Text.Length - 1);
            }

        }
    }
}
