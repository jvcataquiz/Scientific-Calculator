﻿using System;
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
    public partial class Calcu : Form
    {
        string operation;
        double firstvalue;
        double secondvalue;
        double answer;
      
      

        public Calcu()
        {
            InitializeComponent();
        }
       
     
        public void clearzer0()
        {
            if (txtboxdisplay.Text =="0"|| txtboxdisplay.Text == "10^")
            {
                txtboxdisplay.Clear();
            }
        }
        
        private void txtboxdisplay_TextChanged(object sender, EventArgs e)
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
           
            switch (operation)
            { 
                case "x":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue * secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "/":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue / secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "+":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue + secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "-":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue - secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = Math.Pow(10,secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
            }
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Clear();
            txtboxdisplay.Text = "0";
        }

        private void decibtn_Click(object sender, EventArgs e)
        {
            clearzer0();
           
                if (!txtboxdisplay.Text.Contains("."))
                {
                txtboxdisplay.Text = txtboxdisplay.Text + ".";
                }
 
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

        private void additionbtn_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
        }
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            operation = "x";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
        }

        private void tenraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "^";
            clearzer0();
            txtboxdisplay.Text = "10^";
        }

        private void pibtn_Click(object sender, EventArgs e)
        {
            answer = Math.PI;
            txtboxdisplay.Text = answer.ToString();
        }

        private void radiobtnon_CheckedChanged(object sender, EventArgs e)
        {
        this.txtboxdisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
        

        }

        private void radiobtnoff_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcu_Load(object sender, EventArgs e)
        {

        }
    }
}