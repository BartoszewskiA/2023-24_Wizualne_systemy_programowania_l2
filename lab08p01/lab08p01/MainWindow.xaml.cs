using Microsoft.Win32;
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

namespace lab08p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<string> lista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OknoDialogowe oknoDialogowe = new OknoDialogowe();
            if(oknoDialogowe.ShowDialog()==true)
            {
                //tb_lista.Text += "\n" + oknoDialogowe.nazwa + " " + oknoDialogowe.sztuk.ToString();
                lista.Add(oknoDialogowe.nazwa + " " + oknoDialogowe.sztuk.ToString());
                tb_lista.Inlines.Clear();
          
                foreach(string str in lista)
                {
                    tb_lista.Inlines.Add(str+"\n");                  
                }

                combo.Items.Clear();
                foreach (string str in lista)
                {
                    combo.Items.Add(str);
                }
                combo.SelectedIndex = 0;
               
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Lista zakuów (*.liz)|*.liz";
            if(saveFileDialog.ShowDialog()==true)
            {
                StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                foreach (string str in lista)
                {
                    sw.WriteLine(str);
                }
                sw.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int poz = combo.SelectedIndex;
            if (poz < 0) 
                return;
            lista.RemoveAt(poz);
            tb_lista.Inlines.Clear();

            foreach (string str in lista)
            {
                tb_lista.Inlines.Add(str + "\n");
            }

            combo.Items.Clear();
            foreach (string str in lista)
            {
                combo.Items.Add(str);
            }
            combo.SelectedIndex = 0;
        }
    }
}
