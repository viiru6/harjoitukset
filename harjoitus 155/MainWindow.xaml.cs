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

namespace harjoitus_155
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
        static int henkilöA = 0;
        static int avoA = 0;
        private void onClick_henkilö(object sender, RoutedEventArgs e)
        {
            henkilöA++;
            henkilöAutoLaskuri.Text = henkilöA.ToString();
        }

        private void onClickAvo(object sender, RoutedEventArgs e)
        {
            avoA++;
            AvoAutoLaskuri.Text = avoA.ToString();
        }
    }
}
