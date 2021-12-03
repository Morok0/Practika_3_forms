using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_2_forms
{
    public partial class Form1 : Form
    {
        static double f(double x)
        {
            double y;
            if (x < 3) y = Math.Sin(x);
            else if (x >= 9) y = Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            else y = Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5);
            return y;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            double a = 0, b = 0, h = 0;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            

            for (double i = a; i <= b; i += h)
            {   
                str +=""+f(i);
                 str += "\n";
            }
           
             textBox4.Text = Convert.ToString(str+"\n");
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; 
        }
    }
}
