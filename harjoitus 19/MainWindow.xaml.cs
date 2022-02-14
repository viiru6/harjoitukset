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

namespace harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                virhe.Text = "";
                
                if (annettuKerros < maxKerros || annettuKerros > minKerros)
                {
                    kerrosTextBox.Text = "olet nyt kerroksessa:";
                    KerrosNumero.Text = annettuKerros.ToString();
                }
            }
            catch (Exception)
            {
                virhe.Foreground = Brushes.Red;
                virhe.Text = "virhe";
            }
        }
        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            kerrosTextBox.Text = "";
        }
        private int minKerros = 0;
        private int maxKerros = 7;
        int annettuKerros;
        

        private void keyUp(object sender, KeyEventArgs e)
        {
            try//nollaa virhe tekstin ja tallentaa kirjoitetun numeron muuttujaksi
            {
                virhe.Text = "";
                annettuKerros = Convert.ToInt32(kerrosTextBox.Text);
            }
            catch (Exception)//virhe ilmoitus
            {
                virhe.Foreground = Brushes.Green;
                virhe.Text = "syötä numero";
            }
            finally
            {
                if (annettuKerros < maxKerros ^ annettuKerros > minKerros)//jos numero liian korkea tai matala
                {
                    virhe.Foreground = Brushes.Red;
                    virhe.Text = "numero liian korkea tai matala";
                    kerrosTextBox.Text = "";
                }
                else
                {
                    KerrosNumero.Text = annettuKerros.ToString();//tulostaa numeron jos se on 1-6
                    kerrosTextBox.Text = "";
                    virhe.Foreground = Brushes.Black;
                }
            }
        }
        private void keyDown(object sender, KeyEventArgs e)
        {
            virhe.Text = "";
        }
    }
}
