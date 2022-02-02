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
        private void keittiönValotONpäällä(object sender, RoutedEventArgs e)
        {
            KeittiönValotStatus.Foreground = Brushes.Green;
            KeittiönValotStatus.Text = "Keittiön valot ovat päällä";
        }
        private void keittiönValotEIpäällä(object sender, RoutedEventArgs e)
        {
            KeittiönValotStatus.Foreground = Brushes.Red;
            KeittiönValotStatus.Text = "Keittiön valot eivät ole päällä";
        }

        private void OloHuonenValotEIpäällä(object sender, RoutedEventArgs e)
        {
            OlohuoneenValotStatus.Foreground = Brushes.Red;
            OlohuoneenValotStatus.Text = "olohuoneen valot eivät ole päällä";
        }

        private void OloHuoneenValotONpäällä(object sender, RoutedEventArgs e)
        {
            OlohuoneenValotStatus.Foreground = Brushes.Green;
            OlohuoneenValotStatus.Text = "olohuoneen valot ovat päällä";
        }

        private void OviONLukossa(object sender, RoutedEventArgs e)
        {
            oviLukossaStatus.Foreground = Brushes.Green;
            oviLukossaStatus.Text = "ovi on lukossa";
        }

        private void OviEIoleLukossa(object sender, RoutedEventArgs e)
        {
            oviLukossaStatus.Foreground = Brushes.Red;
            oviLukossaStatus.Text = "ovi ei ole lukossa";
        }
        static double läm = 20D;
        private void lämpötilaNostoNappiOnClick(object sender, RoutedEventArgs e)
        {

            läm = läm + 0.5D;
            lämpötila.Text = läm.ToString();
        }
        private void lämpötilaVähennysNappiOnClick(object sender, RoutedEventArgs e)
        {

            läm = läm - 0.5D;
            lämpötila.Text = läm.ToString();
        }
    }
}
