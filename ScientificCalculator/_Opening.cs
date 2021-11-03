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
    public partial class _Opening : Form
    {
        public _Opening()
        {
            InitializeComponent();
        }
        private void loading_Click(object sender, EventArgs e)
        {

        }

        

        public string welcomestr;
        public int count;
        private void _Opening_Load(object sender, EventArgs e)
        {
            welcome.Text = "";
            count = 1;
            welcomestr = "WELCOME";
            timer2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            loading.Value += 1;
            if (loading.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Calcu calcunew = new Calcu();
                calcunew.Show();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            welcome.Text = welcomestr.Substring(0, count);
            count++;
            if (welcome.Text.Length == welcomestr.Length)
            {
                timer2.Enabled = false;
                return;
            }
           
        }

    }
}
