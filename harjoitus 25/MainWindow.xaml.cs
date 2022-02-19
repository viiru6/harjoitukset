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
            virheText.Foreground = Brushes.Red;//asettaa virheTextille värin
            virheText.Text = "";//resetoi virhe textin
            if(joukkueValinta == 1)//kun joukkue kissat on valittu ja käyttäjä lisää pelaajan annettujen tietojen mukaan
            {
                taulu1Joukkue.Items.Remove(pelaajaMäärä1.ToString());//poistaa pelaaja määrän taulusta
                if (b1 == 0)//tulostaa joukkueen tiedot kerran ja asettaa muuttujan niin että ne eivät
                            //tulostu uudelleen ennen tyhjennystä eli metodiea t1()
                {
                    taulu1Joukkue.Items.Add("joukkue:\nkissat\nkotikaupunki:\nTampere\npelaajat:");
                    b1 = 1;
                }
                taulu1.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);//tallentaa käyttäjän antaman etunimen muuttujaan
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);//tallentaa käyttäjän antaman sukunimen muuttujaan
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);//tallentaa käyttäjän antaman iän muuttujaan
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);//tallentaa käyttäjän antaman pelaaja numeron muuttujaan
                }
                catch
                {
                    virheText.Text = "virhe";
                }
                if (Pelaaja.en != "")//jos EtunimiText ei ole tyhjä
                {
                    if (Pelaaja.sn != "")//jos SukunimiText ei ole tyhjä
                    {
                        List<string> testilista = new List<string>();
                        pelaajaMäärä1 = pelaajaMäärä1 + 1; //tiimin pelaaja laskuri nousee yhdellä
                        taulu1Joukkue.Items.Add(pelaajaMäärä1.ToString());//tulostaa uuden pelaaja määrän
                        taulu1.Items.Add(en);
                        taulu1.Items.Add(sn);
                        taulu1.Items.Add(i);
                        taulu1.Items.Add(p);
                        testilista.Add(en);
                        testilista.Add(sn);
                        testilista.Add(i.ToString());
                        testilista.Add(p.ToString());
                    }
                    else
                    {
                        virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    }
                }
                else
                {
                    virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    taulu1Joukkue.Items.Remove(pelaajaMäärä1.ToString());//korjaa pelaaja määrä laskurin
                    if(pelaajaMäärä1 > 0)
                    {
                        pelaajaMäärä1 = pelaajaMäärä1 - 1;//korjaa pelaaja määrä laskurin
                    }
                }
                taulu1Joukkue.FontSize = 10;
            }
            if(joukkueValinta == 2)
            {
                taulu2Joukkue.Items.Remove(pelaajaMäärä2.ToString());//poistaa pelaaja määrän taulusta
                if (b2 == 0)//tulostaa joukkueen tiedot kerran ja asettaa muuttujan niin että ne eivät
                            //tulostu uudelleen ennen tyhjennystä eli metodiea t1()
                {
                    taulu2Joukkue.Items.Add("joukkue:\nkoirat\nkotikaupunki:\nTurku\npelaajat:");
                    b2 = 1;
                }
                taulu2.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);//tallentaa käyttäjän antaman etunimen muuttujaan
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);//tallentaa käyttäjän antaman sukunimen muuttujaan
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);//tallentaa käyttäjän antaman iän muuttujaan
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);//tallentaa käyttäjän antaman pelaaja numeron muuttujaan
                }
                catch
                {
                    virheText.Text = "virhe";
                }
                if (Pelaaja.en != "")//jos EtunimiText ei ole tyhjä
                {
                    if (Pelaaja.sn != "")//jos SukunimiText ei ole tyhjä
                    {
                        pelaajaMäärä2 = pelaajaMäärä2 + 1; //tiimin pelaaja laskuri nousee yhdellä
                        taulu2Joukkue.Items.Add(pelaajaMäärä2.ToString());//tulostaa uuden pelaaja määrän
                        taulu2.Items.Add(en);
                        taulu2.Items.Add(sn);
                        taulu2.Items.Add(i);
                        taulu2.Items.Add(p);
                    }
                    else
                    {
                        virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    }
                }
                else
                {
                    virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    taulu2Joukkue.Items.Remove(pelaajaMäärä2.ToString());//korjaa pelaaja määrä laskurin
                    if (pelaajaMäärä2 > 0)
                    {
                        pelaajaMäärä2 = pelaajaMäärä2 - 1;//korjaa pelaaja määrä laskurin
                    }
                }
                taulu2Joukkue.FontSize = 10;
            }
            if (joukkueValinta == 3)
            {
                taulu3Joukkue.Items.Remove(pelaajaMäärä3.ToString());//poistaa pelaaja määrän taulusta
                if (b3 == 0)//tulostaa joukkueen tiedot kerran ja asettaa muuttujan niin että ne eivät
                            //tulostu uudelleen ennen tyhjennystä eli metodiea t1()
                {
                    taulu3Joukkue.Items.Add("joukkue:\nrotat\nkotikaupunki:\nHelsinki\npelaajat:");
                    b3 = 1;
                }
                taulu3.FontSize = 10;
                Pelaaja.en = Convert.ToString(EtunimiText.Text);//tallentaa käyttäjän antaman etunimen muuttujaan
                Pelaaja.sn = Convert.ToString(SukunimiText.Text);//tallentaa käyttäjän antaman sukunimen muuttujaan
                try
                {
                    Pelaaja.i = Convert.ToDouble(IkäText.Text);//tallentaa käyttäjän antaman iän muuttujaan
                    Pelaaja.p = Convert.ToInt32(PelaajaNumeroText.Text);//tallentaa käyttäjän antaman pelaaja numeron muuttujaan
                }
                catch
                {
                    virheText.Text = "virhe";
                }
                if (Pelaaja.en != "")//jos EtunimiText ei ole tyhjä
                {
                    if (Pelaaja.sn != "")//jos SukunimiText ei ole tyhjä
                    {
                        pelaajaMäärä3 = pelaajaMäärä3 + 1; //tiimin pelaaja laskuri nousee yhdellä
                        taulu3Joukkue.Items.Add(pelaajaMäärä3.ToString());//tulostaa uuden pelaaja määrän
                        taulu3.Items.Add(en);
                        taulu3.Items.Add(sn);
                        taulu3.Items.Add(i);
                        taulu3.Items.Add(p);
                    }
                    else
                    {
                        virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    }
                }
                else
                {
                    virheText.Text = "täytä kaikki ruudut";//ilmoittaa virheestä
                    taulu3Joukkue.Items.Remove(pelaajaMäärä3.ToString());//korjaa pelaaja määrä laskurin
                    if (pelaajaMäärä3 > 0)
                    {
                        pelaajaMäärä3 = pelaajaMäärä3 - 1;//korjaa pelaaja määrä laskurin
                    }

                }
                taulu3Joukkue.FontSize = 10;
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (en == EtunimiText.Text)//jos annettu etunimi on sama kuin etunimen textbox niin se poistetaan listasta
            {
                if (joukkueValinta == 1)
                {
                    taulu1Joukkue.Items.Remove(pelaajaMäärä1.ToString());
                    if (taulu1.Items.IsEmpty)//jos lista on tyhjä niin kaikki nollataan
                    {
                        taulu1Joukkue.Items.Clear();
                        t1();
                    }
                    else//jos ei ole tyhjä niin pelaaja määrä laskee yhdenllä koska pelaaja on poistettu
                    {
                        pelaajaMäärä1 = pelaajaMäärä1 - 1;
                    }
                    taulu1.Items.Remove(en);
                }
                if (joukkueValinta == 2)//jos annettu etunimi on sama kuin etunimen textbox niin se poistetaan listasta
                {
                    taulu2Joukkue.Items.Remove(pelaajaMäärä2.ToString());
                    if (taulu2.Items.IsEmpty)//jos lista on tyhjä niin kaikki nollataan
                    {
                        taulu2Joukkue.Items.Clear();
                        t2();
                    }
                    else//jos ei ole tyhjä niin pelaaja määrä laskee yhdenllä koska pelaaja on poistettu
                    {
                        pelaajaMäärä2 = pelaajaMäärä2 - 1;
                    }
                    taulu2.Items.Remove(en);
                }
                if (joukkueValinta == 3)//jos annettu etunimi on sama kuin etunimen textbox niin se poistetaan listasta
                {
                    taulu3Joukkue.Items.Remove(pelaajaMäärä3.ToString());
                    if (taulu3.Items.IsEmpty)//jos lista on tyhjä niin kaikki nollataan
                    {
                        taulu3Joukkue.Items.Clear();
                        t3();
                    }
                    else//jos ei ole tyhjä niin pelaaja määrä laskee yhdenllä koska pelaaja on poistettu
                    {
                        pelaajaMäärä3 = pelaajaMäärä3 - 1;
                    }
                    taulu3.Items.Remove(en);
                }
            }
            if (sn == SukunimiText.Text)//jos annettu sukunimi on sama kuin Sukunimen textbox niin se poistetaan listasta
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
                if (i == Convert.ToDouble(IkäText.Text))//jos annettu ikä on sama kuin iän textbox niin se poistetaan listasta
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
                if (p == Convert.ToInt32(PelaajaNumeroText.Text))//jos annettu pelaaja numero on sama kuin
                                                                 //pelaaja numeron textbox niin se poistetaan listasta
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
        private void TallennaNappi_Click(object sender, RoutedEventArgs e)//serialisoinin kokeilu mutta en onnistunut jatkamaan ja serialisoimaan listoja
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