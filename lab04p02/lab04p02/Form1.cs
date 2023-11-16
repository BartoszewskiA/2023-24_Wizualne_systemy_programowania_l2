using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zmienKolor();
        }

        void zmienKolor()
        {
            panel1.BackColor = Color.FromArgb(
                hScrollBar1.Value,
                hScrollBar2.Value,
                hScrollBar3.Value
                );
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            zmienKolor();
        }



        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            zmienKolor();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            zmienKolor();
        }
    }
}
