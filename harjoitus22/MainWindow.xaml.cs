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

namespace harjoitus22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static double IkkunanLeveys ;
        static double IkkunanKorkeus ;
        static double KarminPuunLeveys ;
        static double Pintaala;
        static double karminPiiri;
        static double lasinPintaala;
        private void laskenNappi_Click(object sender, RoutedEventArgs e)
        {
            virheText.Text = "";//virhe ilmoitus katoaa nappia painaessa
            {//näyttää ikkunan ja sen pituudet                   
                karmi.Visibility = Visibility.Visible;
                lasi.Visibility = Visibility.Visible;
                korkeusLabel.Visibility = Visibility.Visible;
                LeveysLabel.Visibility = Visibility.Visible;
                KarminLeveysLabel.Visibility = Visibility.Visible;
                ikkunanLeveysSeparator.Visibility = Visibility.Visible;
                ikkunanKorkeusSeparator.Visibility = Visibility.Visible;
                karminLeveysSeparator.Visibility = Visibility.Visible;
            }
            try
            {
                IkkunanLeveys = Convert.ToDouble(ikkunanLeveysText.Text);//tallentaa käyttäjän antaman numeron muuttujaan
                IkkunanKorkeus = Convert.ToDouble(ikkunanKorkeusText.Text);//tallentaa käyttäjän antaman numeron muuttujaan
                KarminPuunLeveys = Convert.ToDouble(karmipuunLeveysText.Text);//tallentaa käyttäjän antaman numeron muuttujaan
            }
            catch (FormatException)//käyttäjälle ilmoitetaan virheestä
            {
                virheText.Foreground = Brushes.Red;
                virheText.Text = "virheellinen syöte";
                {//piilottaa ikkunan ja sen mitat jos syntyy virhe
                    karmi.Visibility = Visibility.Hidden;
                    lasi.Visibility = Visibility.Hidden;
                    korkeusLabel.Visibility = Visibility.Hidden;
                    LeveysLabel.Visibility = Visibility.Hidden;
                    KarminLeveysLabel.Visibility = Visibility.Hidden;
                    ikkunanLeveysSeparator.Visibility = Visibility.Hidden;
                    ikkunanKorkeusSeparator.Visibility = Visibility.Hidden;
                    karminLeveysSeparator.Visibility = Visibility.Hidden;
                }
            }
            finally
            {//laskee ikkunan mitat ja tulostaa ne käyttäjälle
                Pintaala = IkkunanKorkeus * IkkunanLeveys / 100;
                ikkunanPintaAlaText.Text = Pintaala.ToString() + "cm²";
                karminPiiri = (IkkunanKorkeus + IkkunanKorkeus + IkkunanLeveys + IkkunanLeveys) / 10;
                KarminPiiriText.Text = karminPiiri.ToString() + "cm";
                lasinPintaala = ((IkkunanKorkeus - (KarminPuunLeveys * 2)) * (IkkunanLeveys - (KarminPuunLeveys * 2))) / 100;
                LasinPintaAlaText.Text = lasinPintaala.ToString() + "cm²";
                korkeusLabel.Content = "H: " + IkkunanKorkeus.ToString() + "cm";
                LeveysLabel.Content = "L: " + IkkunanLeveys.ToString() + "cm";
                KarminLeveysLabel.Content = "w: " + KarminPuunLeveys.ToString() + "cm";
            }
        }
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {//tupla klikkauksella voi tyhjentää kirjoitus ruudut
            ikkunanLeveysText.Text = "";
            ikkunanKorkeusText.Text = "";
            karmipuunLeveysText.Text = "";
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
