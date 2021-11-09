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
    public partial class Calcu : Form
    {
        string operation;
        double firstvalue;
        double secondvalue;
        double answer;
        string[] parts = null;
        public Calcu()
        {
            InitializeComponent();
        }

        private void radiobtnon_CheckedChanged(object sender, EventArgs e)
        {

            this.txtboxdisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            
            this.txtboxdisplay.Enabled = true;
            this.parenthesisopen.Enabled = true;
            this.parenthesisclose.Enabled = true;
            this.mcbtn.Enabled = true;
            this.mrbtn.Enabled = true;
            this.mminusbtn.Enabled = true;
            this.mplusbtn.Enabled = true;
            this.percentagebtn.Enabled = true;
            this.cebtn.Enabled = true;
            this.clearbtn.Enabled = true;
            this.divisionbtn.Enabled = true;
            this.multiplicationbtn.Enabled = true;
            this.btn9.Enabled = true;
            this.btn8.Enabled = true;
            this.btn7.Enabled = true;
            this.tenraisedbtn.Enabled = true;
            this.eraisedbtn.Enabled = true;
            this.xraisedbtn.Enabled = true;
            this.cubebtn.Enabled = true;
            this.squarebtn.Enabled = true;
            this.secondbtn.Enabled = true;
            this.minusbtn.Enabled = true;
            this.btn6.Enabled = true;
            this.btn5.Enabled = true;
            this.btn4.Enabled = true;
            this.logbtn.Enabled = true;
            this.lnbtn.Enabled = true;
            this.xsquarerootofany.Enabled = true;
            this.cuberootbtn.Enabled = true;
            this.sqrtbtn.Enabled = true;
            this.oneoverxbtn.Enabled = true;
            this.additionbtn.Enabled = true;
            this.btn3.Enabled = true;
            this.btn2.Enabled = true;
            this.btn1.Enabled = true;
            this.EEbtn.Enabled = true;
            this.ebtn.Enabled = true;
            this.tanbtn.Enabled = true;
            this.cosinebtn.Enabled = true;
            this.sinebtn.Enabled = true;
            this.factorialbtn.Enabled = true;
            this.equalbtn.Enabled = true;
            this.decibtn.Enabled = true;
            this.btnzero.Enabled = true;
            this.randbtn.Enabled = true;
            this.pibtn.Enabled = true;
            this.tanhbtn.Enabled = true;
            this.coshbtn.Enabled = true;
            this.sinhbtn.Enabled = true;
            this.Radbtn.Enabled = true;
            this.label1.Enabled = true;
        }
        private void radiobtnoff_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void clearzer0()
        {
            if (txtboxdisplay.Text == "0" || txtboxdisplay.Text == "10^")
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


        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Clear();
            txtboxdisplay.Text = "0";
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

        private void decibtn_Click(object sender, EventArgs e)
        {
            clearzer0();

            if (!txtboxdisplay.Text.Contains("."))
            {
                txtboxdisplay.Text = txtboxdisplay.Text + ".";
            }

        }

        private void additionbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "+";
            operation = "+";

        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "-";
            operation = "-";
            
        }
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "x";
            operation = "x";
            
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = txtboxdisplay.Text + "/";
            operation = "/";
          
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "x":
                    parts = txtboxdisplay.Text.Split("x");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue * secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "/":
                    parts = txtboxdisplay.Text.Split("/");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue / secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "+":
                   
                    parts = txtboxdisplay.Text.Split("+");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue + secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "-":
                    parts = txtboxdisplay.Text.Split("-");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue - secondvalue;
                    txtboxdisplay.Text =  Convert.ToString(answer);
                    break;
                case "^":
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = Math.Pow(10, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
            }
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



        private void Calcu_Load(object sender, EventArgs e)
        {

        }
    }
}
