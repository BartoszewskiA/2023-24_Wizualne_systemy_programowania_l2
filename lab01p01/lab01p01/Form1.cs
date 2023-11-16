using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox_02.Text = "";
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*label3.Text = textBox1.Text;*/
            string s1 = textBox1.Text;
            string s2 = textBox_02.Text;
            label3.Text = "["+s1+"] ["+s2+"]";
        }
    }
}
