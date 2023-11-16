using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03p01
{
    public partial class Form1 : Form
    {

        Color old;
        int mina = 0;
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.BackColor=old;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if(mina ==0 )
            {
                old = panel1.BackColor;
                panel1.BackColor = Color.Red;
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            random = new Random();
            mina = random.Next(4);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (mina == 1)
            {
                old = panel2.BackColor;
                panel2.BackColor = Color.Red;
            }
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (mina == 2)
            {
                old = panel3.BackColor;
                panel3.BackColor = Color.Red;
            }
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (mina == 3)
            {
                old = panel4.BackColor;
                panel4.BackColor = Color.Red;
            }
        }
    }
}
