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

        private void LisääNappi_Click(object sender, RoutedEventArgs e)
        {
            CheckBox b = new CheckBox();
            Lista2.Items.Add(b);
            t = Convert.ToString(Teksti.Text);
            Lista.Items.Add(t);
        }
        private void PoistaNappi_OnClick(object sender, RoutedEventArgs e)
        {
            if (t == Teksti.Text)
            {
                Lista.Items.Remove(t);
                Lista2.Items.Remove(b);
            }
        }


        private void TyhjennäNappi_Click(object sender, RoutedEventArgs e)
        {
            Lista.Items.Clear();
            Lista2.Items.Clear();
        }
        
    }
}
