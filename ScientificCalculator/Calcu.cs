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
        string[] parts;
        double memoryStore;
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
            if (txtboxdisplay.Text == "0")
            {
                txtboxdisplay.Clear();
                answer = 0;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
          
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
            operation = "+";
            txtboxdisplay.Text = txtboxdisplay.Text + "+";
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            operation = "-";
            txtboxdisplay.Text = txtboxdisplay.Text + "-";
        }
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            operation = "x";
            txtboxdisplay.Text = txtboxdisplay.Text + "x";
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            operation = "/";
            txtboxdisplay.Text = txtboxdisplay.Text + "/";
        
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
           
            switch (operation)
            {
                case "x":
                    answer = 1;
                    parts = txtboxdisplay.Text.Split("x");
                   
                    for (int i = 0; i < parts.Length; i++)
                    {
                        answer *= (Convert.ToDouble(parts[i]));
                    }
                   
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "/":
                    answer = 0;
                    parts = txtboxdisplay.Text.Split("/");
                    for (int i = 0; i < parts.Length; i++)
                    {
                            answer /= (Convert.ToDouble(parts[i]));
                        if (answer==0)
                        {
                            answer = (Convert.ToDouble(parts[i]));
                        }
                     
                    }
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "+":
                    parts = txtboxdisplay.Text.Split("+");
                    for (int i = 0; i < parts.Length; i++)
                    {
                        answer = answer + Convert.ToDouble(parts[i]);
                    }
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "-":
                    answer = 0;
                    parts = txtboxdisplay.Text.Split("-");
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (answer == 0)
                        {
                            answer = (Convert.ToDouble(parts[0])) - Convert.ToDouble(parts[i]);
                        }
                        else
                        {
                            answer -= Convert.ToDouble(parts[i]);
                        }
                        

                    }
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "%":
                    parts = txtboxdisplay.Text.Split("%");
                    firstvalue = Convert.ToDouble(parts[0]);
                    answer = firstvalue / 100;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^":
                    parts = txtboxdisplay.Text.Split("^");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(10, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^2":
                    parts = txtboxdisplay.Text.Split("^2");
                    firstvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue,2);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^3":
                    parts = txtboxdisplay.Text.Split("^3");
                    firstvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue, 3);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^*":
                    parts = txtboxdisplay.Text.Split("^*");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(firstvalue, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "e^":
                    parts = txtboxdisplay.Text.Split("e^");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(2.71828, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "1/":
                    parts = txtboxdisplay.Text.Split("1/");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = 1 / secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "2√":
                    parts = txtboxdisplay.Text.Split("2√");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Sqrt(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "3√":
                    parts = txtboxdisplay.Text.Split("3√");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cbrt(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "√'":
                    parts = txtboxdisplay.Text.Split("√'");
                    firstvalue = Convert.ToDouble(parts[1]);
                    secondvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue,(1/secondvalue));
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "ln":
                    parts = txtboxdisplay.Text.Split("ln");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Log(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "log10":
                    parts = txtboxdisplay.Text.Split("log10-");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Log10(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "sin":
                    parts = txtboxdisplay.Text.Split("sin");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Sin(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "cos":
                    parts = txtboxdisplay.Text.Split("cos");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cos(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "tan":
                    parts = txtboxdisplay.Text.Split("tan");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Tan(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "sinh":
                    parts = txtboxdisplay.Text.Split("sinh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Sinh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "cosh":
                    parts = txtboxdisplay.Text.Split("cosh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cosh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "tanh":
                    parts = txtboxdisplay.Text.Split("tanh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Tanh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
          
            }
        }
        private void tenraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "^";
            if (!txtboxdisplay.Text.Contains("^"))
            {
                clearzer0();
                txtboxdisplay.Text =   "10 ^" + txtboxdisplay.Text;
            }
           
        }

        private void pibtn_Click(object sender, EventArgs e)
        {
              clearzer0();
              txtboxdisplay.Text = txtboxdisplay.Text + "3.1416";
        }


        private void ebtn_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "2.7183";
        }

        private void Calcu_Load(object sender, EventArgs e)
        {

        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            operation = "^2";
            if (!txtboxdisplay.Text.Contains("^2"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "^2";
            }
        }

        private void cubebtn_Click(object sender, EventArgs e)
        {
            operation = "^3";
            if (!txtboxdisplay.Text.Contains("^3"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "^3";
            }
        }

        private void xraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "^*";
            if (!txtboxdisplay.Text.Contains("^*"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "^*";
            }
        }

        private void eraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "e^";
            if (!txtboxdisplay.Text.Contains("e^"))
            {
                clearzer0();
                txtboxdisplay.Text = "e^" + txtboxdisplay.Text;
            }
        }

        private void oneoverxbtn_Click(object sender, EventArgs e)
        {
            operation = "1/";
            if (!txtboxdisplay.Text.Contains("1/"))
            {
                clearzer0();
                txtboxdisplay.Text = "1/" + txtboxdisplay.Text;
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            operation = "2√";
            if (!txtboxdisplay.Text.Contains("2√"))
            {
                clearzer0();
                txtboxdisplay.Text = "2√" + txtboxdisplay.Text;
            }
        }

        private void cuberootbtn_Click(object sender, EventArgs e)
        {
           
            operation = "3√";
            if (!txtboxdisplay.Text.Contains("3√"))
            {
                clearzer0();
                txtboxdisplay.Text = "3√" + txtboxdisplay.Text;
            }
        }

        private void xsquarerootofany_Click(object sender, EventArgs e)
        {
            operation = "√'";
            if (!txtboxdisplay.Text.Contains("√'"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "√'" ;
            }
        }

        private void lnbtn_Click(object sender, EventArgs e)
        {
            operation = "ln";
            if (!txtboxdisplay.Text.Contains("ln"))
            {
                clearzer0();
                txtboxdisplay.Text ="ln" + txtboxdisplay.Text;
            }
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            operation = "log10";
            if (!txtboxdisplay.Text.Contains("log10"))
            {
                clearzer0();
                txtboxdisplay.Text = "log10-" + txtboxdisplay.Text;
            }
        }


        private void sinebtn_Click(object sender, EventArgs e)
        {
            operation = "sin";
            if (!txtboxdisplay.Text.Contains("sin"))
            {
                clearzer0();
                txtboxdisplay.Text = "sin" + txtboxdisplay.Text;
            }
        }

        private void cosinebtn_Click(object sender, EventArgs e)
        {
            operation = "cos";
            if (!txtboxdisplay.Text.Contains("cos"))
            {
                clearzer0();
                txtboxdisplay.Text = "cos" + txtboxdisplay.Text;
            }
        }

        private void tanbtn_Click(object sender, EventArgs e)
        {
            operation = "tan";
            if (!txtboxdisplay.Text.Contains("tan"))
            {
                clearzer0();
                txtboxdisplay.Text = "tan" + txtboxdisplay.Text;
            }
        }

        private void percentagebtn_Click(object sender, EventArgs e)
        {
            operation = "%";
            if (!txtboxdisplay.Text.Contains("%"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "%";
            }
        }

        private void sinhbtn_Click(object sender, EventArgs e)
        {
            operation = "sinh";
            if (!txtboxdisplay.Text.Contains("sinh"))
            {
                clearzer0();
                txtboxdisplay.Text = "sinh" + txtboxdisplay.Text;
            }
        }

        private void coshbtn_Click(object sender, EventArgs e)
        {
            operation = "cosh";
            if (!txtboxdisplay.Text.Contains("cosh"))
            {
                clearzer0();
                txtboxdisplay.Text = "cosh" + txtboxdisplay.Text;
            }
        }

        private void tanhbtn_Click(object sender, EventArgs e)
        {
            operation = "tanh";
            if (!txtboxdisplay.Text.Contains("tanh"))
            {
                clearzer0();
                txtboxdisplay.Text = "tanh" + txtboxdisplay.Text;
            }
        }

        private void mcbtn_Click(object sender, EventArgs e)
        {
            memoryStore = 0;
            return;
        }

        private void mplusbtn_Click(object sender, EventArgs e)
        {
            txtboxdisplay.Text = memoryStore.ToString();
            return;
        }

        private void mminusbtn_Click(object sender, EventArgs e)
        {
            memoryStore -= Convert.ToDouble(answer);
            return;
        }

        private void mrbtn_Click(object sender, EventArgs e)
        {
            memoryStore += Convert.ToDouble(answer);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (measurementGroupBox.Visible == true)
            {
                measurementGroupBox.Visible = false;
            }
            else
            {
                measurementGroupBox.Visible = true;
            }
        }

        private void factorialbtn_Click(object sender, EventArgs e)
        {

        }

        private void parenthesisopen_Click(object sender, EventArgs e)
        {

        }

        private void parenthesisclose_Click(object sender, EventArgs e)
        {

        }

        private void EEbtn_Click(object sender, EventArgs e)
        {

        }

        private void Radbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
