using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magical_Quest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Top_button1_Click(object sender, EventArgs e)
        {
            lb.Text = "うえーい";
            top_button1.Dispose();
            top_button2.Dispose();

            Thread.Sleep(500);

            lb.Text = "戦闘";

            top_button3.Enabled = true;
            top_button3.Visible = true;
        }

        private void Top_button2_Click(object sender, EventArgs e)
        {
            lb.Text = "しょぼーん";
            top_button1.Enabled = false;
            top_button1.Visible = false;
            top_button2.Enabled = false;
            top_button2.Visible = false;
        }

        private void top_button3_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
