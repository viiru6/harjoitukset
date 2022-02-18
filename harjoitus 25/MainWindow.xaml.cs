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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace harjoitus_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Serializable]
    public partial class MainWindow : Window
    {
        //muuuttujat
        public static string en;
        public static string sn;
        public static double i;
        public static string j;
        public static int p;
        int joukkueValinta = 1;
        int pelaajaMäärä1 = 0;
        int pelaajaMäärä2 = 0;
        int pelaajaMäärä3 = 0;
        int b1 = 0;
        int b2 = 0;
        int b3 = 0;
        public MainWindow()
        {
            InitializeComponent();
            kissatNappi.IsChecked = true;//kun ohjelman käynnistää niin yksi joukkue valinta on jo valmiina
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            virheText.Foreground = Brushes.Red;//asettaa virhe textille värin
            virheText.Text = "";//resetoi virhe textin
            if(joukkueValinta == 1)//kun joukkue kissat on valittu ja käyttäjä lisää pelaajan
            {
                pelaajaMäärä1 = pelaajaMäärä1 + 1; //tiimin pelaaja laskuri nousee yhdellä
                if (b1 == 0)//tulostaa joukkueen tiedot kerran ja asettaa muuttujan niin että ne eivät tulostu uudelleen ennen tyhjennystä
                {
                    taulu1Joukkue.Items.Add("joukkue:\nkissat\nkotikaupunki:\nTampere\npelaajat:");
                    b1 = 1;
                }
                taulu1Joukkue.Items.Remove((pelaajaMäärä1 - 1).ToString());//poistaa edellisen tulostetun pelaaja määrän
                taulu1Joukkue.Items.Add(pelaajaMäärä1.ToString());//tulostaa uuden pelaaja määrän
                taulu1.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);//tallentaa käyttäjän antaman etunimen muuttujaan
                                                                //ja lisää sen tauluun
                taulu1.Items.Add(en);
                taulu1Joukkue.FontSize = 10;
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);//tallentaa käyttäjän antaman sukunimen muuttujaan
                                                                 //ja lisää sen tauluun
                taulu1.Items.Add(sn);
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);//tallentaa käyttäjän antaman iän muuttujaan
                                                               //ja lisää sen tauluun
                    taulu1.Items.Add(i);
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);//tallentaa käyttäjän antaman pelaaja numeron muuttujaan
                                                                        //ja lisää sen tauluun
                                                                        //sama koodi toistuu vielä kaksi kertaa mutta niissä tieto tallentuu eri
                                                                        //tauluihin
                    taulu1.Items.Add(p);
                }
                catch
                {
                    virheText.Text = "virhe";
                }
            }
            if(joukkueValinta == 2)
            {
                pelaajaMäärä2 = pelaajaMäärä2 + 1;
                if (b2 == 0)
                {
                    taulu2Joukkue.Items.Add("joukkue:\nkoirat\nkotikaupunki:\nTurku\npelaajat:");
                    b2 = 1;
                }
                taulu2Joukkue.Items.Remove((pelaajaMäärä2 - 1).ToString());
                taulu2Joukkue.Items.Add(pelaajaMäärä2.ToString());
                taulu2.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);
                taulu2.Items.Add(en);
                taulu2Joukkue.FontSize = 10;
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);
                taulu2.Items.Add(sn);
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);
                    taulu2.Items.Add(i);
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);
                    taulu2.Items.Add(p);
                }
                catch
                {
                    virheText.Text = "virhe";
                }
            }
            if(joukkueValinta == 3)
            {
                pelaajaMäärä3 = pelaajaMäärä3 + 1;
                if (b3 == 0)
                {
                    taulu3Joukkue.Items.Add("joukkue:\nrotat\nkotikaupunki:\nHelsinki\npelaajat:");
                    b3 = 1;
                }
                taulu3Joukkue.Items.Remove((pelaajaMäärä3 - 1).ToString());
                taulu3Joukkue.Items.Add(pelaajaMäärä3.ToString());
                taulu3.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);
                taulu3.Items.Add(en);
                taulu3Joukkue.FontSize = 10;
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);
                taulu3.Items.Add(sn);
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);
                    taulu3.Items.Add(i);
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);
                    taulu3.Items.Add(p);
                }
                catch
                {
                    virheText.Text = "virhe";
                }
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (en == EtunimiText.Text)
            {
                if (joukkueValinta == 1)
                {
                    if (taulu1.Items.IsEmpty)
                    {
                        taulu1Joukkue.Items.Clear();
                        t1();
                    }
                    taulu1.Items.Remove(en);
                }
                if (joukkueValinta == 2)
                {
                    if (taulu2.Items.IsEmpty)
                    {
                        taulu2Joukkue.Items.Clear();
                        t2();
                    }
                    taulu2.Items.Remove(en);
                }
                if (joukkueValinta == 3)
                {
                    if (taulu3.Items.IsEmpty)
                    {
                        taulu3Joukkue.Items.Clear();
                        t3();
                    }
                    taulu3.Items.Remove(en);
                }
            }
            if (sn == SukunimiText.Text)
            {
                if (joukkueValinta == 1)
                {
                    taulu1.Items.Remove(sn);
                }
                if (joukkueValinta == 2)
                {
                    taulu2.Items.Remove(sn);
                }
                if (joukkueValinta == 3)
                {
                    taulu3.Items.Remove(sn);
                }
            }
            try
            {
                if (i == Convert.ToDouble(IkäText.Text))
                {
                    if (joukkueValinta == 1)
                    {
                        taulu1.Items.Remove(i);
                    }
                    if (joukkueValinta == 2)
                    {
                        taulu2.Items.Remove(i);
                    }
                    if (joukkueValinta == 3)
                    {
                        taulu3.Items.Remove(i);
                    }
                }
            }
            catch
            {
                virheText.Text = "virhe";
            }
            try
            {
                if (p == Convert.ToInt32(PelaajaNumeroText.Text))
                {
                    if (joukkueValinta == 1)
                    {
                        taulu1.Items.Remove(p);
                    }
                    if (joukkueValinta == 2)
                    {
                        taulu2.Items.Remove(p);
                    }
                    if (joukkueValinta == 3)
                    {
                        taulu3.Items.Remove(p);
                    }
                }
            }
            catch
            {
                virheText.Text = "virhe";
            }
        }
        private void kissatNappi_Checked(object sender, RoutedEventArgs e)
        {
            joukkueValinta = 1;
        }
        private void KoiratNappi_Checked(object sender, RoutedEventArgs e)
        {
            joukkueValinta = 2;
        }
        private void RotatNappi_Checked(object sender, RoutedEventArgs e)
        {
            joukkueValinta = 3;
        }
        private void t1()//tyhjennys on metodin sisässä jotta myös PoistaNappi voi käyttää sitä
        {
            taulu1.Items.Clear();//tyjentää pelaaja taulun
            taulu1Joukkue.Items.Clear();//tyjentää joukkueen tiedot taulusta
            b1 = 0;//asettaa muuttujan uudelleen että joukkueen tiedot voidaan tulostaa uudelleen
            pelaajaMäärä1 = 0;//nollaa tiimin pelaaja laskurin
        }
        private void tyhjennä1_Click(object sender, RoutedEventArgs e)
        {
            t1();
        }
        private void t2()
        {
            taulu2.Items.Clear();//tyjentää pelaaja taulun
            taulu2Joukkue.Items.Clear();//tyjentää joukkueen tiedot taulusta
            b2 = 0;//asettaa muuttujan uudelleen että joukkueen tiedot voidaan tulostaa uudelleen
            pelaajaMäärä2 = 0;//nollaa tiimin pelaaja laskurin
        }
        private void tyhjennä2_Click(object sender, RoutedEventArgs e)
        {
            t2();
        }
        private void t3()
        {
            taulu3.Items.Clear();//tyjentää pelaaja taulun
            taulu3Joukkue.Items.Clear();//tyjentää joukkueen tiedot taulusta
            b3 = 0;//asettaa muuttujan uudelleen että joukkueen tiedot voidaan tulostaa uudelleen
            pelaajaMäärä3 = 0;//nollaa tiimin pelaaja laskurin
        }
        private void tyhjennä3_Click(object sender, RoutedEventArgs e)
        {
            t3();
        }
        private void TallennaNappi_Click(object sender, RoutedEventArgs e)
        {
            Joukkue joukkue = new Joukkue { joukkueenNimi = "hevoset" };
            Stream writestream = new FileStream("harjoitus25.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writestream, joukkue);
            writestream.Close();
        }
        private void LataaNappi_Click(object sender, RoutedEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream readstream = new FileStream("harjoitus25.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Joukkue luettu = (Joukkue)formatter.Deserialize(readstream);
            virheText.Text = luettu.joukkueenNimi.ToString();
        }
    }
}