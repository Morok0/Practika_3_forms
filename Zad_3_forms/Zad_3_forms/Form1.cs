using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_3_forms
{
    public partial class Form1 : Form
    {
        static void f(double a, double b, double h)
        {   
            string str = "";
            double f = 0;
            for (double i = a; i <= b; i += h)
            {
                
                if (Math.Abs(i) < a)
                    f = 0;
                else if (Math.Abs(i) > a)
                    f = (i - a) / (i + a);
                else if (Math.Abs(i) == a)
                    f = 1;
                str += ""+f;
                str += "\n";
                
            }
            MessageBox.Show(" "+str);

        }

         static void f(double x, out double y)
        {   
            string str = "";
            double a = 1;
            y = x < a
            ? 0
            : x > a
            ? (x - a) / (x + a)
            : 1;
            str += "" + y;
            str += "\n";
             MessageBox.Show(" " + str);
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
            f(a, b, h);
            
            for (double x = a; x <= b; x += h)
            {   
               f(x, out double y);//не знаю как его присвоить какой либо переменной чтобы выводить одно окно 
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; 
        }
    }
}
