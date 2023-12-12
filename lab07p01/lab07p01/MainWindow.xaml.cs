using System;
using System.Collections.Generic;
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

namespace lab07p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const String ET01 = "Liczba znaków: ";
        const String ET02 = "Liczba znaków bez spacji: ";
        const String ET03 = "Liczba akapitów: ";
        public MainWindow()
        {
            InitializeComponent();
            licznik_1.Text = ET01;
            licznik_2.Text = ET02;
            licznik_3.Text = ET03;
        }

        private void przelicz_Click(object sender, RoutedEventArgs e)
        {
            String s = poleTekstowe.Text;
            int l_znakow = s.Length;
            int l_spacji = 0;
            int l_enterow = 0;

            for (int i = 0; i <s.Length ; i++)
                if (s[i]==' ') l_spacji++;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '\n') l_enterow++;

            licznik_1.Text = ET01 + l_znakow;
            licznik_2.Text=ET02 + (l_znakow - l_spacji).ToString();
            licznik_3.Text = ET03 + l_enterow;
        }
    }
}
