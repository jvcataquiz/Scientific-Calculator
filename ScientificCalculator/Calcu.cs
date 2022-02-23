using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
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
        StreamWriter outputFile;
        string filedata;
        public Calcu()
        {
            InitializeComponent();
           
        }

        private void radiobtnon_CheckedChanged(object sender, EventArgs e)
        {

            this.txtboxdisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            
            this.txtboxdisplay.Enabled = true;
          
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
            this.label1.Enabled = true;
            this.Radbtn.Enabled = true;
            this.richTextBoxHistory.Visible = true;
            this.History.Visible = true;
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
            textBoxSave.Text = txtboxdisplay.Text + " + ";
            operation = "+";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
            
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            textBoxSave.Text = txtboxdisplay.Text + " - ";
            operation = "-";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();
            
        }
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            textBoxSave.Text = txtboxdisplay.Text + " x ";
            operation = "x";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();

        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            textBoxSave.Text = txtboxdisplay.Text + " / ";
            operation = "/";
            firstvalue = Convert.ToDouble(txtboxdisplay.Text);
            txtboxdisplay.Clear();


        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
          
           
            switch (operation)
            {

                case "x":
                    textBoxSave.Text = textBoxSave.Text + txtboxdisplay.Text + " = ";
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue * secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "/":
                    textBoxSave.Text = textBoxSave.Text + txtboxdisplay.Text + " = ";
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue / secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "+":
                    textBoxSave.Text = textBoxSave.Text + txtboxdisplay.Text + " = ";
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue + secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "-":
                    textBoxSave.Text = textBoxSave.Text + txtboxdisplay.Text + " = ";
                    secondvalue = Convert.ToDouble(txtboxdisplay.Text);
                    answer = firstvalue - secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;

                case "^":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("^");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(10, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^2":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("^2");
                    firstvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue,2);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^3":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("^3");
                    firstvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue, 3);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "^*":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("^*");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(firstvalue, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "e^":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("e^");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(2.71828, secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "1/":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("1/");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = 1 / secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "2√":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("2√");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Sqrt(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "3√":

                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("3√");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cbrt(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "√'":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("√'");
                    firstvalue = Convert.ToDouble(parts[1]);
                    secondvalue = Convert.ToDouble(parts[0]);
                    answer = Math.Pow(firstvalue,(1/secondvalue));
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "ln":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("ln");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Log(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "log10":
                    textBoxSave.Text =  txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("log10-");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Log10(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "sin":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("sin");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer =Math.Sin(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "cos":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("cos");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cos(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "tan":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("tan");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Tan(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "sinh":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("sinh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Sinh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "cosh":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("cosh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Cosh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "tanh":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("tanh");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Tanh(secondvalue);
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "neg":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("-");
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = secondvalue * -1;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;
                case "facto":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    answer = 1;
                    parts = txtboxdisplay.Text.Split("!");
                    int num =Convert.ToInt16(parts[0]) ;

                    for (int i = 1; i < num + 1; i++)
                    {
                        answer *= (Convert.ToDouble(i));
                    }

                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;

                case "EE":
                    textBoxSave.Text = txtboxdisplay.Text + " = ";
                    parts = txtboxdisplay.Text.Split("E");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Math.Pow(10,Convert.ToDouble(parts[1]));
                    answer = firstvalue * secondvalue;
                    txtboxdisplay.Text = Convert.ToString(answer);
                    break;

            }
          
            outputFile = File.AppendText("History.txt");
            outputFile.WriteLine("\nDate: " + DateTime.Now.ToString());
            outputFile.WriteLine(textBoxSave.Text);
            outputFile.WriteLine("Answer: " + answer );
            outputFile.Close();

        }
        private void tenraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "^";
            if (!txtboxdisplay.Text.Contains("^"))
            {
                clearzer0();
                txtboxdisplay.Text =   "10 ^" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
           
        }

        private void pibtn_Click(object sender, EventArgs e)
        {
              clearzer0();
              txtboxdisplay.Text = txtboxdisplay.Text + "3.1416";
            textBoxSave.Text = txtboxdisplay.Text;
        }


        private void ebtn_Click(object sender, EventArgs e)
        {
            clearzer0();
            txtboxdisplay.Text = txtboxdisplay.Text + "2.7183";
            textBoxSave.Text = txtboxdisplay.Text;
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
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void cubebtn_Click(object sender, EventArgs e)
        {
            operation = "^3";
            if (!txtboxdisplay.Text.Contains("^3"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "^3";
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void xraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "^*";
            if (!txtboxdisplay.Text.Contains("^*"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "^*";
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void eraisedbtn_Click(object sender, EventArgs e)
        {
            operation = "e^";
            if (!txtboxdisplay.Text.Contains("e^"))
            {
                clearzer0();
                txtboxdisplay.Text = "e^" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void oneoverxbtn_Click(object sender, EventArgs e)
        {
            operation = "1/";
            if (!txtboxdisplay.Text.Contains("1/"))
            {
                clearzer0();
                txtboxdisplay.Text = "1/" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            operation = "2√";
            if (!txtboxdisplay.Text.Contains("2√"))
            {
                clearzer0();
                txtboxdisplay.Text = "2√" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void cuberootbtn_Click(object sender, EventArgs e)
        {
           
            operation = "3√";
            if (!txtboxdisplay.Text.Contains("3√"))
            {
                clearzer0();
                txtboxdisplay.Text = "3√" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void xsquarerootofany_Click(object sender, EventArgs e)
        {
            operation = "√'";
            if (!txtboxdisplay.Text.Contains("√'"))
            {
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "√'" ;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void lnbtn_Click(object sender, EventArgs e)
        {
            operation = "ln";
            if (!txtboxdisplay.Text.Contains("ln"))
            {
                clearzer0();
                txtboxdisplay.Text ="ln" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            operation = "log10";
            if (!txtboxdisplay.Text.Contains("log10"))
            {
                clearzer0();
                txtboxdisplay.Text = "log10-" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }


        private void sinebtn_Click(object sender, EventArgs e)
        {
            operation = "sin";
            if (!txtboxdisplay.Text.Contains("sin"))
            {
                clearzer0();
                txtboxdisplay.Text = "sin" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void cosinebtn_Click(object sender, EventArgs e)
        {
            operation = "cos";
            if (!txtboxdisplay.Text.Contains("cos"))
            {
                clearzer0();
                txtboxdisplay.Text = "cos" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void tanbtn_Click(object sender, EventArgs e)
        {
            operation = "tan";
            if (!txtboxdisplay.Text.Contains("tan"))
            {
                clearzer0();
                txtboxdisplay.Text = "tan" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void percentagebtn_Click(object sender, EventArgs e)
        {
            
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text ;
                textBoxSave.Text = txtboxdisplay.Text + "%" ;
                answer = Convert.ToDouble(txtboxdisplay.Text) / 100;
                txtboxdisplay.Text = answer.ToString();

        }

        private void sinhbtn_Click(object sender, EventArgs e)
        {
            operation = "sinh";
            if (!txtboxdisplay.Text.Contains("sinh"))
            {
                clearzer0();
                txtboxdisplay.Text = "sinh" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void coshbtn_Click(object sender, EventArgs e)
        {
            operation = "cosh";
            if (!txtboxdisplay.Text.Contains("cosh"))
            {
                clearzer0();
                txtboxdisplay.Text = "cosh" + txtboxdisplay.Text;
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

        private void tanhbtn_Click(object sender, EventArgs e)
        {
            operation = "tanh";
            if (!txtboxdisplay.Text.Contains("tanh"))
            {
                clearzer0();
                txtboxdisplay.Text = "tanh" + txtboxdisplay.Text;
                 textBoxSave.Text = txtboxdisplay.Text;
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

        private void factorialbtn_Click(object sender, EventArgs e)
        {
            operation = "facto";
            if (!txtboxdisplay.Text.Contains("!"))
            {
                clearzer0();
                txtboxdisplay.Text =  txtboxdisplay.Text + "!";
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }


        private void EEbtn_Click(object sender, EventArgs e)
        {
            operation = "EE";
            if (!txtboxdisplay.Text.Contains("E"))
            {
                
                clearzer0();
                txtboxdisplay.Text = txtboxdisplay.Text + "E";
                textBoxSave.Text = txtboxdisplay.Text;
            }
        }

       

        private void textBoxSave_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void randbtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            
            txtboxdisplay.Text = rand.Next(1, 1000).ToString();
        }

        private void Radbtn_Click(object sender, EventArgs e)
        {
            
            operation = "neg";
            if (!txtboxdisplay.Text.Contains("--"))
            {

                clearzer0();
                txtboxdisplay.Text = "-" +  txtboxdisplay.Text ;
                textBoxSave.Text = txtboxdisplay.Text;

            }
        }

        private void Calcu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("THANK YOU FOR USING THIS APPLICATION!!!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            filedata = File.ReadAllText("History.txt");
            richTextBoxHistory.AppendText(filedata);
           
        }

        private void richTextBoxHistory_TextChanged(object sender, EventArgs e)
        {
            richTextBoxHistory.SelectionStart = richTextBoxHistory.Text.Length;
            richTextBoxHistory.ScrollToCaret();
          
        }

        private void History_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "History.txt");
        }
    }
}
