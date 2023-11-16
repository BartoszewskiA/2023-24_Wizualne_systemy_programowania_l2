using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            //a= int.Parse(textBox1.Text);
            if (!int.TryParse(textBox1.Text, out a))
            {
                a = 0;
                textBox1.Text = a.ToString();
            }
            if (!int.TryParse(textBox2.Text, out b))
            {
                b = 0;
                textBox2.Text = b.ToString();
            }
            if (!int.TryParse(textBox3.Text, out c))
            {
                c = 0;
                textBox3.Text = c.ToString();
            }

            int delta = b * b - 4 * a * c;
            label4.Text ="delta = " + delta.ToString();
            String s = "";
            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x1 = Math.Round(x1, 5);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = Math.Round(x2, 5);
                s = "x1 = " + x1.ToString() + "\nx2 = " + x2.ToString();
            }
            else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                x0 = Math.Round(x0, 5);
                s = "x0 = " + x0.ToString(); ;
            }
            else
            {
                s = "Brak rozwiązań\n w zbiorze R";
            }

            label5.Text = s;
        }
    }
}
