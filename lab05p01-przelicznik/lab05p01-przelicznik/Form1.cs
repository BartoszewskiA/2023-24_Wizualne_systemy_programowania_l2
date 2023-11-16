using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05p01_przelicznik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            przygotuj();
        }

        void przygotuj()
        {
            tb_in.Text = 0.ToString();
            tb_out.Text = 0.ToString();
            rb_in_pln.Checked = true;
            rb_out_euro.Checked = true;
            opisy_walut();
        }

        void opisy_walut()
        {
            if (rb_in_pln.Checked)
                la_in.Text = "PLN";
            else if (rb_in_euro.Checked)
                la_in.Text = "EURO";
            else
                la_in.Text = "USD";

            if (rb_out_pln.Checked)
                la_out.Text = "PLN";
            else if (rb_out_euro.Checked)
                la_out.Text = "EURO";
            else
                la_out.Text = "USD";
        }

        double przelicz(double x)
        {
            double y = 0, posredniczaca = 0;

            if (rb_in_pln.Checked)
                posredniczaca = x;
            else if (rb_in_euro.Checked)
                posredniczaca = x * 4.50;
            else 
                posredniczaca = x * 4.12;

            if (rb_out_pln.Checked)
                y = posredniczaca;
            else if (rb_out_euro.Checked)
                y = posredniczaca / 4.5;
            else
                y = posredniczaca / 4.12;
            y = Math.Round(y, 2);
            return y;
        }

        private void rb_in_pln_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
           tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_in_euro_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_in_usd_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_out_pln_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_out_euro_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void rb_out_usd_CheckedChanged(object sender, EventArgs e)
        {
            opisy_walut();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }

        private void hsb_in_Scroll(object sender, ScrollEventArgs e)
        {
            tb_in.Text = (hsb_in.Value / 100.0).ToString();
            tb_out.Text = przelicz(Double.Parse(tb_in.Text)).ToString();
        }
    }
}
