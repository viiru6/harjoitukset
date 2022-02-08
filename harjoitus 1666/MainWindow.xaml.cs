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

namespace harjoitus_1666
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
        static decimal km = 0m;
        static decimal m = 0m;
        private void KMOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                virhe.Text = "";//virhe tekstin resettaus
                m = Convert.ToDecimal(m1.Text);//käyttäjän numero tallentuu muuttujaan
                decimal mToKm = m * 0.621371m;//numeron muunnos
                km1.Text = mToKm.ToString();//muunnettu numero muuttuu stringiksi ja näytetään käyttäjälle
            }
            catch (Exception)//jos käyttäjä tekee virheen kuten kirjoittaa numeron tai jättää ruudun tyhjäksi niin näytetään virhe ilmoitus
            {
                virhe.Text = "virhe";
            }
        }
        private void MOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                virhe.Text = "";//virhe tekstin resettaus
                km = Convert.ToDecimal(km1.Text);//käyttäjän numero tallentuu muuttujaan
                decimal kmToM = km * 1.609344m;//numeron muunnos
                m1.Text = kmToM.ToString();//muunnettu numero muuttuu stringiksi ja näytetään käyttäjälle
            }
            catch (Exception)//jos käyttäjä tekee virheen kuten kirjoittaa numeron tai jättää ruudun tyhjäksi niin näytetään virhe ilmoitus
            {
                virhe.Text = "virhe";
            }
        }
    }
}
