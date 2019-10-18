namespace Magical_Quest
{
    partial class Form2
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
            this.lb = new System.Windows.Forms.Label();
            this.top_button1 = new System.Windows.Forms.Button();
            this.top_button2 = new System.Windows.Forms.Button();
            this.top_button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(100, 23);
            this.lb.TabIndex = 0;
            this.lb.Text = "はじめる";
            // 
            // top_button1
            // 
            this.top_button1.Location = new System.Drawing.Point(2, 97);
            this.top_button1.Name = "top_button1";
            this.top_button1.Size = new System.Drawing.Size(246, 23);
            this.top_button1.TabIndex = 1;
            this.top_button1.Text = "はじめたい";
            this.top_button1.Click += new System.EventHandler(this.Top_button1_Click);
            // 
            // top_button2
            // 
            this.top_button2.Location = new System.Drawing.Point(2, 126);
            this.top_button2.Name = "top_button2";
            this.top_button2.Size = new System.Drawing.Size(246, 23);
            this.top_button2.TabIndex = 2;
            this.top_button2.Text = "始めたくない";
            this.top_button2.Click += new System.EventHandler(this.Top_button2_Click);
            // 
            // top_button3
            // 
            this.top_button3.Enabled = false;
            this.top_button3.Location = new System.Drawing.Point(2, 126);
            this.top_button3.Name = "top_button3";
            this.top_button3.Size = new System.Drawing.Size(246, 23);
            this.top_button3.TabIndex = 3;
            this.top_button3.Text = "技1";
            this.top_button3.Visible = false;
            this.top_button3.Click += new System.EventHandler(this.top_button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.top_button1);
            this.Controls.Add(this.top_button2);
            this.Controls.Add(this.top_button3);
            this.Controls.Add(this.lb);
            this.Name = "Form2";
            this.Text = "マジカルクエスト";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button top_button1;
        private System.Windows.Forms.Button top_button2;
        private System.Windows.Forms.Button top_button3;
    }
}