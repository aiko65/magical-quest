using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Magical_Quest
{
    class program: Form
    {
        private Label lb;
        private Button top_button1;
        private Button top_button2;

        public static void Main()
        {
            Application.Run(new program());
        }
        public program()
        {
            this.Text = "マジカルクエスト";
            this.Width = 250; this.Height = 150;

            lb = new Label();
            lb.Text = "はじめる";
            lb.Dock = DockStyle.Top;

            top_button1 = new Button();
            top_button1.Text = "はじめたい";
            top_button1.Dock = DockStyle.Bottom;

            top_button1.Click += new EventHandler(topbt1_Click);

            top_button2 = new Button();
            top_button2.Text = "あんまりはじめたくない";
            top_button2.Dock = DockStyle.Bottom;

            top_button2.Click += new EventHandler(topbt2_Click);

            lb.Parent = this;
            top_button1.Parent = this;
            top_button2.Parent = this;
        }
        public void topbt1_Click(Object sender, EventArgs e)
        {
            lb.Text = "うえーい";
            top_button1.Controls.Clear();
        }
        public void topbt2_Click(Object sender, EventArgs e)
        {
            lb.Text = "しょぼーん";
            top_button1.Controls.Clear();
        }
    }
}
