using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab09p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\memory.dat";
        String sct_prefiks = "Liczba rat: ";
        int ile_rat = 1;
        double rata = 0;
        double kwota=0;
        public MainWindow()
        {
            InitializeComponent();
            scrol.Maximum = 32;
            scrol.Minimum = 1;
            scrol.Value = 1;
            tbl_liczba_rat.Text = sct_prefiks + Math.Round(scrol.Value).ToString();
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            tbl_liczba_rat.Text = sct_prefiks + Math.Round(scrol.Value).ToString();
            ile_rat = (int)Math.Round(scrol.Value);
            
            if(!Double.TryParse(tb_kwota.Text, out kwota))
            { 
                kwota = 0;
                tb_kwota.Text = "0";
            }
            rata = Math.Round(kwota/ile_rat, 2);
            tbl_wynik.Text = "Rata= "+rata.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            String wpis = "";
            wpis += kwota.ToString();
            wpis += " rat ";
            wpis += ile_rat;
            wpis += " wysokosc raty = ";
            wpis += rata;
            wpis += "\n";
            File.AppendAllText(path, wpis);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            File.CreateText(path);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(this);
            window1.ShowDialog();
        }
    }
}
