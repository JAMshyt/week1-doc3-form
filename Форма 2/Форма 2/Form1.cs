using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void f(double x, out double y)
        {
            if ((x + 2) <= 1) y = x * x;
            else if (1 < (x + 2) & (x + 2) < 10) y = 1 / (x + 2);
            else y = x + 2;
        }

        static double f(double x)
        {
            double y;
            if ((x + 2) <= 1) y = x * x;
            else if (1 < (x + 2) & (x + 2) < 10) y = 1 / (x + 2);
            else y = x + 2;
            return y;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            double a = 0, b = 0, h = 0;
                try
                {
                    do
                    {
                        a = Convert.ToDouble(numericUpDown1.Value);
                        b = Convert.ToDouble(numericUpDown2.Value);
                        h = Convert.ToDouble(numericUpDown3.Value);
                    if (a < b) break;
                    else
                    {
                        richTextBox1.Text = "а Должно быть меньше б";
                        break;
                    }
                    } while (true);
                }
                catch
                {
                richTextBox1.Text = "Ошибка, заново";
                }
            for (double i = a; i <= b; i += h)
                richTextBox1.Text += ""+ f(i)+"\n";

            richTextBox1.Text += "\n";
            for (double i = a; i <= b; i += h)
            {
                double y;
                f(i, out  y);
                richTextBox1.Text += "" + f(i) + "\n";

            }
        }
    }
}
