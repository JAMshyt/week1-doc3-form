using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace форма_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            if (x % 5 == 0)
            {
                double res = x / 5;
                return res;
            }
            else if ((x * 10) % 5 == 0)
            {
                double res = x / 5;
                return res;
            }
            else { 
                double res = ++x;
                return res;
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            do
            {
                try
                {
                    a = Convert.ToDouble(textBox2.Text);
                    break;
                }
                catch
                {
                    MessageBox.Show("Error");
                    break;
                }
            } while (true);
            textBox1.Text = "" + f(a);
        }
    }
}
