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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string en;
            string sn;
            string oID;
            string sp;
            int p;
            en = Convert.ToString(EtunimiText.Text);
            sn = Convert.ToString(SukunimiText.Text);
            oID = Convert.ToString(OpiskelijaIDText.Text);
            sp = Convert.ToString(SähköpostiText.Text);
            try
            {
                p = Convert.ToInt32(PuhelinnumeroText.Text);
            }
            catch(FormatException)
            {

            }

        }
    }
}
