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

namespace harjoitus_21
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
        private void omenaBox_Checked(object sender, RoutedEventArgs e)//jos valittu niin kirjoittaa "ostoskorissa" ja lisää tuotteen ostoslistalle
        {
            omenaText.Foreground = Brushes.Green;
            omenaText.Text = "ostoskorissa";
            ostosLista.Items.Add("omena");
        }
        private void omenaBox_IsNotChecked(object sender, RoutedEventArgs e)//jos ei valittu niin tyhjää tekstin ja poistaa tuotteen ostoslistalta
        {
            omenaText.Text = "";
            ostosLista.Items.Remove("omena");
        }

        private void banaaniBox_Checked(object sender, RoutedEventArgs e)//jos valittu niin kirjoittaa "ostoskorissa" ja lisää tuotteen ostoslistalle
        {
            banaaniText.Foreground = Brushes.Green;
            banaaniText.Text = "ostoskorissa";
            ostosLista.Items.Add("banaani");
        }
        private void banaaniBox_IsNotChecked(object sender, RoutedEventArgs e)//jos ei valittu niin tyhjää tekstin ja poistaa tuotteen ostoslistalta
        {
            banaaniText.Text = "";
            ostosLista.Items.Remove("banaani");
        }
        private void leipäBox_Checked(object sender, RoutedEventArgs e)//jos valittu niin kirjoittaa "ostoskorissa" ja lisää tuotteen ostoslistalle
        {
            leipäText.Foreground = Brushes.Green;
            leipäText.Text = "ostoskorissa";
            ostosLista.Items.Add("leipä");
        }
        private void leipäBox_IsNotChecked(object sender, RoutedEventArgs e)//jos ei valittu niin tyhjää tekstin ja poistaa tuotteen ostoslistalta
        {
            leipäText.Text = ""; 
            ostosLista.Items.Remove("leipä");
        }
        private void OstaNappi_Click(object sender, RoutedEventArgs e)
        {
            ostosLista.Items.Clear(); //tyhjentää ostos listan
            if (omenaBox.IsChecked != false)//jos tuote on valitt niin se lisätään ostetuttujen tuotteiden listalle
            {
                ostetutTuotteet.Items.Add("omena");//jos tuote on valitt niin se lisätään ostetuttujen tuotteiden listalle
            }
            if (banaaniBox.IsChecked != false)
            {
                ostetutTuotteet.Items.Add("banaani");//jos tuote on valitt niin se lisätään ostetuttujen tuotteiden listalle
            }
            if (leipäBox.IsChecked != false)
            {
                ostetutTuotteet.Items.Add("leipä");//jos tuote on valitt niin se lisätään ostetuttujen tuotteiden listalle
            }
            omenaBox.IsChecked = false;//tyhjentää Check Boxin
            banaaniBox.IsChecked = false;//tyhjentää Check Boxin
            leipäBox.IsChecked = false;//tyhjentää Check Boxin
        }
    }
}
