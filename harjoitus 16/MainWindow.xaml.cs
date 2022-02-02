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

namespace harjoitus_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        int i = 0;
        private void onClick(object sender, RoutedEventArgs e)
        {
            i++;
            try
            {
                virheilmoitukset.Text = "";
                kilometrit.Text = "0";
                mailit.Text = "0";
                if (i % 2 != 0)
                {
                    double km;
                    km = Convert.ToDouble(kilometrit);
                    double kmToM = km * 0.621371D;
                    kilometrit.Text = km.ToString();
                    mailit.Text = kmToM.ToString();
                }
                else
                {
                    string sm = mailit.ToString();
                    double m = Convert.ToDouble(sm);
                    double mToKm = m * 1.609344D;
                    mailit.Text =  m.ToString();
                    kilometrit.Text = mToKm.ToString();
                }
            }
            catch(Exception)
            {
                virheilmoitukset.Text = "virhe";
                Console.Beep();
                Console.Beep();
            }
        }
    }
}
