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

namespace harjoitus_18
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
        static double tulos;
        static double numero1 = 0D;
        static double numero2 = 0D;
        private void summaOnClick(object sender, RoutedEventArgs e)
        {
            merkki.FontSize = 25;//fontin korjaus
            merkki.Text = "+";
            KertoMerkki.Text = "";
            JakoMerkki.Text = "";
            try
            {
                numero1 = Convert.ToDouble(numeroKenttä1.Text);//numeron convertointi ja lasku toimitus
                numero2 = Convert.ToDouble(numeroKenttä2.Text);
                tulos = numero1 + numero2;
                TulosText.Text = tulos.ToString();
            }
            catch ( Exception)//virheen ilmoitus käyttäjälle. pääasissa jos ei käytä pilkkua vaan pistettä
            {
                TulosText.Text = "virhe";
            }
        }
        private void erotusOnClick(object sender, RoutedEventArgs e)
        {
            merkki.FontSize = 25;//fontin korjaus
            merkki.Text = "-";
            KertoMerkki.Text = "";
            JakoMerkki.Text = "";
            try
            {
                numero1 = Convert.ToDouble(numeroKenttä1.Text);//numeron convertointi ja lasku toimitus
                numero2 = Convert.ToDouble(numeroKenttä2.Text);
                tulos = numero1 - numero2;
                TulosText.Text = tulos.ToString();
            }
            catch (Exception)//virheen ilmoitus käyttäjälle. pääasissa jos ei käytä pilkkua vaan pistettä
            {
                TulosText.Text = "virhe";
            }
        }
        private void jakoOnClick(object sender, RoutedEventArgs e)
        {
            merkki.Text = "";//fontin korjaus
            KertoMerkki.Text = "";
            JakoMerkki.FontSize = 10;
            JakoMerkki.Text = "➗";
            try
            {
                numero1 = Convert.ToDouble(numeroKenttä1.Text);//numeron convertointi ja lasku toimitus
                numero2 = Convert.ToDouble(numeroKenttä2.Text);
                tulos = numero1 / numero2;
                TulosText.Text = tulos.ToString();
            }
            catch (Exception)//virheen ilmoitus käyttäjälle. pääasissa jos ei käytä pilkkua vaan pistettä
            {
                TulosText.Text = "virhe";
            }
        }
        private void kertoOnClick(object sender, RoutedEventArgs e)
        {
            merkki.Text = "";//fontin korjaus
            KertoMerkki.Text = "•";
            JakoMerkki.Text = "";
            try
            {
                numero1 = Convert.ToDouble(numeroKenttä1.Text);//numeron convertointi ja lasku toimitus
                numero2 = Convert.ToDouble(numeroKenttä2.Text);
                tulos = numero1 * numero2;
                TulosText.Text = tulos.ToString();
            }
            catch (Exception)//virheen ilmoitus käyttäjälle. pääasissa jos ei käytä pilkkua vaan pistettä
            {
                TulosText.Text = "virhe";
            }
        }     
    }
}
