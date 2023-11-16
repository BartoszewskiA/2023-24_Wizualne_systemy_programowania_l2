using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02p02
{
    public partial class Form1 : Form
    {
        private int ile = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = ile.ToString();
            colorSetter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueSetter(+1);
            colorSetter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valueSetter(-1);
            colorSetter();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            valueSetter(0);
            colorSetter();
        }

        private void colorSetter()
        {
            if (ile > 0) label1.ForeColor = Color.Green;
            else if (ile == 0) label1.ForeColor = Color.Black;
            else label1.ForeColor = Color.Red;
        }

        private void valueSetter(int f)
        {
            switch(f)
            {
                case 1: ile++; break;
                case 0: ile=0; break;
                case -1: ile--; break;
            }
            label1.Text = ile.ToString();
        }
    }
}
