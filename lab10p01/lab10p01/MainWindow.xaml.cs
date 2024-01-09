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

namespace lab10p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\log.txt";

        int liczba_sesji = 0;
        int czas_start = 0;
        int czas_sesji = 0;
        int czas_poprzeednich_sesji = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(File.Exists(path))
            {
                FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                liczba_sesji = int.Parse(sr.ReadLine());
                liczba_sesji++;
                czas_poprzeednich_sesji = int.Parse(sr.ReadLine());
                sr.Close();
            } else
            {
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(0); // liczba sesji
                DateTime dateTime = DateTime.Now;
                czas_start = dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second; 
                sw.WriteLine(0); // laczny czas poprzednich sesji
                sw.Close();
            }
            string s = "";
            s += "liczba sesji= ";
            s += liczba_sesji;
            s += "\n";
            s += "Czas start= ";
            s += czas_start;
            s += "\n";
            s += "Łaczny czas = ";
            s += czas_poprzeednich_sesji;
            s += "\n";
            textBox01.Text = s;
        }
         
        private void Window_Closed(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(liczba_sesji);
            DateTime dateTime = DateTime.Now;
            int aktualny_czas = dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second;
            czas_sesji = czas_poprzeednich_sesji+ (aktualny_czas - czas_start);
            sw.WriteLine(czas_sesji);
            sw.Close();
        }
    }
}
