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

namespace harjoitus_26
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
        string t;
        int Numero;
        public void LisääNappi_Click(object sender, RoutedEventArgs e)
        {
            Lista.FontSize = 11.38;//korjaa fontin
            if(Teksti.Text != "")//jos teksti kenttä ei ole tyhjä niin luo uuden checkboxin ja kirjoittaa sen tooltipim ja sitten sisää sen listaan2
            {
                CheckBox b = new CheckBox();
                b.ToolTip = "omistatko kirjan?";
                Lista2.Items.Add(b);
            }
            Lista.Items.Add(t);//lisää kirjoitetun tekstin listaan
            if(Teksti.Text != "")
            {
                Numero = Numero + 1;//nostaa kirjalaskuria yhdellä
            }
            numero.Text = Numero.ToString();//tulostaa kirjojen määrän
        }
        private void PoistaNappi_OnClick(object sender, RoutedEventArgs e)
        {
            if (Lista.Items.Contains(t))//jos listassa on viimeksi kirjoitettu teksti niin listoista poistetaan viimeisimmät lisäykset ja numero laskuri laskee yhdellä
            {
                if (Numero > 0)
                {
                    Lista2.Items.RemoveAt(Lista2.Items.Count - 1);
                    Lista.Items.RemoveAt(Lista.Items.Count - 1);
                    Numero = Numero - 1;
                }
                numero.Text = Numero.ToString();//tulostaa kirja laskurin
            }
        }
        private void Teksti_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Convert.ToString(Teksti.Text);//tallentaa kirjoitetun tekstin kirjoittaessa
        }
        private void PoistaNappi_DoubleClick(object sender, MouseButtonEventArgs e)//tyhjentää listat, resetoi kirja laskurin ja tulostaa laskurin
        {
            Lista.Items.Clear();
            Lista2.Items.Clear();
            Numero = 0;
            numero.Text = Numero.ToString();
        }
    }
}
