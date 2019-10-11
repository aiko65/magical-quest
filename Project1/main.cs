using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Project1
{
    class program 
    {
        public static void Main()
        {
            Form fm = new Form();
            Label lb = new Label();
            lb.Text = "Hello,world!";
            lb.Parent = fm;
            Application.Run(fm);
        }
    }
}
