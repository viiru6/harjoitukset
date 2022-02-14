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

namespace harjoitus_17
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
        private void keittiönValotONpäällä(object sender, RoutedEventArgs e)//jos valojen ruutu on täytetty
        {
            KeittiönValotStatus.Foreground = Brushes.Green;//muuttaa keittiön valojen tekstin vihreäksi 
            KeittiönValotStatus.Text = "Keittiön valot ovat päällä";
        }
        private void keittiönValotEIpäällä(object sender, RoutedEventArgs e)//jos valojen ruutu ei ole täytetty
        {
            KeittiönValotStatus.Foreground = Brushes.Red;//muuttaa keittiön valojen tekstin punaiseksi 
            KeittiönValotStatus.Text = "Keittiön valot eivät ole päällä";
        }
        private void OloHuonenValotEIpäällä(object sender, RoutedEventArgs e)//jos olohuoneen ruutu ei ole täytetty
        {
            OlohuoneenValotStatus.Foreground = Brushes.Red;//muuttaa olohuoneen valojen tekstin punaiseksi 
            OlohuoneenValotStatus.Text = "olohuoneen valot eivät ole päällä";
        }
        private void OloHuoneenValotONpäällä(object sender, RoutedEventArgs e)//jos olohuoneen ruutu on täytetty
        {
            OlohuoneenValotStatus.Foreground = Brushes.Green;//muuttaa olohuoneen valojen tekstin vihreäksi 
            OlohuoneenValotStatus.Text = "olohuoneen valot ovat päällä";
        }
        private void OviONLukossa(object sender, RoutedEventArgs e)//jos oven ruutu on täytetty
        {
            oviLukossaStatus.Foreground = Brushes.Green;//muuttaa oven tekstin vihreäksi 
            oviLukossaStatus.Text = "ovi on lukossa";
        }
        private void OviEIoleLukossa(object sender, RoutedEventArgs e)//jos oven ruutu ei ole täytetty
        {
            oviLukossaStatus.Foreground = Brushes.Red;//muuttaa oven tekstin punaiseksi 
            oviLukossaStatus.Text = "ovi ei ole lukossa";
        }
        static double läm = 20D;
        private void lämpötilaNostoNappiOnClick(object sender, RoutedEventArgs e)//jos nosta lämpöä nappia painetaan
        {

            läm = läm + 0.5D;
            lämpötila.Text = läm.ToString();
        }
        private void lämpötilaVähennysNappiOnClick(object sender, RoutedEventArgs e)//jos laske lämpöä nappia painetaan
        {

            läm = läm - 0.5D;
            lämpötila.Text = läm.ToString();
        }
    }
}
