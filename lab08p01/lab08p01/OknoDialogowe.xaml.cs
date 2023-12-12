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
using System.Windows.Shapes;

namespace lab08p01
{
    /// <summary>
    /// Logika interakcji dla klasy OknoDialogowe.xaml
    /// </summary>
    public partial class OknoDialogowe : Window
    {
        public String nazwa;
        public int sztuk;
        
        public OknoDialogowe()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, RoutedEventArgs e)
        {
            if(textBox_nazwa.Text.Length == 0) 
            {
                MessageBox.Show("Pole Nazwa musi być wypełnione", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                nazwa = textBox_nazwa.Text;
            }
            nazwa = textBox_nazwa.Text;
            if (Int32.TryParse(textBox_sztuk.Text, out sztuk) != true)
            {
                MessageBox.Show("Pole Sztuk powinno zawierać liczbę", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            this.DialogResult = true;
        }
    }
}
