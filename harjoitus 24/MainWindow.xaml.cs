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

namespace harjoitus_24
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
        static Random r = new Random();
        int Random1 = r.Next(1, 40);
        int Random2 = r.Next(1, 40);
        int Random3 = r.Next(1, 40);
        int Random4 = r.Next(1, 40);
        int Random5 = r.Next(1, 40);
        int Random6 = r.Next(1, 40);
        int Random7 = r.Next(1, 40);
        int i = 0;
        Boolean lotto = true;
        Boolean vikinglotto = false;
        Boolean eurojackpot = false;
        static int rivit;
        
        private void uusiRiviNappi_Click(object sender, RoutedEventArgs e)
        {
            rivienMäärä.Foreground = Brushes.Black;
            try
            {
                rivit = Convert.ToInt32(rivienMäärä.Text);//tallentaa käyttäjän valitseman rivien määrän muuttujaan
            }
            catch(FormatException)//jos käyttäjä tekee virheen niin siitä ilmoitetaan
            {
                rivienMäärä.Foreground = Brushes.Red;
                rivienMäärä.Text = "virhe";
                lotto = false;
                vikinglotto = false;
                eurojackpot = false;
                lottoValo.Fill = new SolidColorBrush(Colors.Red);
                VikinglottoValo.Fill = new SolidColorBrush(Colors.Red);
                EurojackpotValo.Fill = new SolidColorBrush(Colors.Red);
                LottoRivit.Items.Clear();
            }
            if(lotto)//loton rivit
            {
                for(;rivit > 0;)
                {
                    i = i + 1;
                    Random1 = r.Next(1, 40);
                    Random2 = r.Next(1, 40);
                    Random3 = r.Next(1, 40);
                    Random4 = r.Next(1, 40);
                    Random5 = r.Next(1, 40);
                    Random6 = r.Next(1, 40);
                    Random7 = r.Next(1, 40);
                    LottoRivit.Items.Add("rivi :" + i);
                    LottoRivit.Items.Add(
                        Random1.ToString() + " " + 
                        Random2.ToString() + " " + 
                        Random3.ToString() + " " + 
                        Random4.ToString() + " " + 
                        Random5.ToString() + " " + 
                        Random6.ToString() + " " + 
                        Random7.ToString() + "\n");
                    rivit = rivit - 1;
                }
            }
            if (vikinglotto)//viking loton rivit
            {
                for (; rivit > 0;)
                {
                    i = i + 1;
                    Random1 = r.Next(1, 48);
                    Random2 = r.Next(1, 48);
                    Random3 = r.Next(1, 48);
                    Random4 = r.Next(1, 48);
                    Random5 = r.Next(1, 48);
                    Random6 = r.Next(1, 48);
                    LottoRivit.Items.Add("rivi :" + i);
                    LottoRivit.Items.Add(
                        Random1.ToString() + " " + 
                        Random2.ToString() + " " + 
                        Random3.ToString() + " " + 
                        Random4.ToString() + " " + 
                        Random5.ToString() + " " + 
                        Random6.ToString()+"\n");
                    rivit = rivit - 1;
                }
            }
            if (eurojackpot)//eurojackpotin rivit
            {
                for (; rivit > 0;)
                {
                    i = i + 1;
                    Random1 = r.Next(1, 50);
                    Random2 = r.Next(1, 50);
                    Random3 = r.Next(1, 50);
                    Random4 = r.Next(1, 50);
                    Random5 = r.Next(1, 50);
                    Random6 = r.Next(1, 10);
                    Random7 = r.Next(1, 10);
                    LottoRivit.Items.Add("rivi :" + i); 
                    LottoRivit.Items.Add(
                         Random1.ToString() + " " +
                         Random2.ToString() + " " +
                         Random3.ToString() + " " +
                         Random4.ToString() + " " +
                         Random5.ToString() + "\nTähti Numerot: " +
                         Random6.ToString() + " ja " +
                         Random7.ToString() + "\n");
                    rivit = rivit - 1;
                }
            }
        }
        private void PelinValintaNappiLotto(object sender, RoutedEventArgs e)
        {
            lotto = true;
            vikinglotto = false;
            eurojackpot = false;
            lottoValo.Fill = new SolidColorBrush(Colors.Green);
            VikinglottoValo.Fill = new SolidColorBrush(Colors.Red);
            EurojackpotValo.Fill = new SolidColorBrush(Colors.Red);
            LottoRivit.Items.Clear();
            i = 0;
        }
        private void PelinValintaNappiLVikingotto(object sender, RoutedEventArgs e)
        {
            lotto = false;
            vikinglotto = true;
            eurojackpot = false;
            lottoValo.Fill = new SolidColorBrush(Colors.Red);
            VikinglottoValo.Fill = new SolidColorBrush(Colors.Green);
            EurojackpotValo.Fill = new SolidColorBrush(Colors.Red);
            LottoRivit.Items.Clear();
            i = 0;
        }
        private void PelinValintaNappiLEurojackpot(object sender, RoutedEventArgs e)
        {
            lotto = false;
            vikinglotto = false;
            eurojackpot = true;
            lottoValo.Fill = new SolidColorBrush(Colors.Red);
            VikinglottoValo.Fill = new SolidColorBrush(Colors.Red);
            EurojackpotValo.Fill = new SolidColorBrush(Colors.Green);
            LottoRivit.Items.Clear();
            i = 0;
        }
    }
}

