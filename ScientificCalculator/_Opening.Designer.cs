
namespace ScientificCalculator
{
    partial class _Opening
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.White;
            this.loading.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loading.Location = new System.Drawing.Point(25, 162);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(593, 54);
            this.loading.TabIndex = 0;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1427;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Algerian", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(127, 51);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(401, 89);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "WELCOME";
            // 
            // _Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 254);
            this.ControlBox = false;
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.loading);
            this.Name = "_Opening";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening";
            this.Load += new System.EventHandler(this._Opening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label welcome;
    }
}