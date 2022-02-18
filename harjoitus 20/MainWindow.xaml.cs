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

namespace harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string en;
        public static string sn;
        public static string oID;
        public static string sp;
        public static int p;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSaveToFileButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnLoadFromFileButton_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            virheText.Text = "";
            en = Convert.ToString(EtunimiText.Text);
            TextBlock textblock = new TextBlock();
            this.taulu.Children.Add(textblock);
            textblock.Text = Opiskeliija.en;
            textblock.FontSize = 10;
            sn = Convert.ToString(SukunimiText.Text);
            TextBlock textblock1 = new TextBlock();
            this.taulu.Children.Add(textblock1);
            textblock.Text = Opiskeliija.sn;
            textblock.FontSize = 10;
            oID = Convert.ToString(OpiskelijaIDText.Text);
            TextBlock textblock2 = new TextBlock();
            this.taulu.Children.Add(textblock2);
            textblock.Text = Opiskeliija.oID;
            textblock.FontSize = 10;
            sp = Convert.ToString(SähköpostiText.Text);
            TextBlock textblock3 = new TextBlock();
            this.taulu.Children.Add(textblock3);
            textblock.Text = Opiskeliija.sp;
            textblock.FontSize = 10;
            try
            {
                p = Convert.ToInt32(PuhelinnumeroText.Text);
            }
            catch(FormatException)
            {
                virheText.Foreground = Brushes.Red;
                virheText.Text = "anna numero";
            }
            TextBlock textblock4 = new TextBlock();
            this.taulu.Children.Add(textblock4);
            textblock.Text = Opiskeliija.p.ToString();
            textblock.FontSize = 10;
            EtunimiText.Clear();
            SukunimiText.Clear();
            OpiskelijaIDText.Clear();
            SähköpostiText.Clear();
            PuhelinnumeroText.Clear();
        }
    }
}
