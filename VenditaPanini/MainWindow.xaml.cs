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

namespace VenditaPanini
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double prezzo = 0;
            if (rdbNormale.IsChecked == true)
            {
                prezzo += 1.00;
            }
            else if (rdbIntegrale.IsChecked == true)
            {
                prezzo += 1.50;
            }
            else if (rdb5Cereali.IsChecked == true)
            {
                prezzo += 1.50;
            }

            if (rdbProsciutto.IsChecked == true)
            {
                prezzo += 0.50;
            }
            else if (rdbMortadella.IsChecked == true)
            {
                prezzo += 0.50;
            }
            else if (rdbHamburger.IsChecked == true)
            {
                prezzo += 1.50;
            }
            else if (rdbSalsiccia.IsChecked == true)
            {
                prezzo += 1.50;
            }

            if (ckbCipolla.IsChecked == true)
            {
                prezzo += 0.30;
            }
            else if (ckbFormaggio.IsChecked == true)
            {
                prezzo += 0.30;
            }
            if (ckbInsalata.IsChecked == true)
            {
                prezzo += 0.30;
            }
            else if (ckbPeperoni.IsChecked == true)
            {
                prezzo += 0.30;
            }
          
            txtPrezzo.Text = prezzo.ToString();

        }
    }
}
