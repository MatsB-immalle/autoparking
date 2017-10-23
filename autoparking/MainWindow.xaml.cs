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

namespace autoparking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Ingang_Click(object sender, RoutedEventArgs e)
        {

            Teller.Content = counter + 1;
            counter++;

        }


        private void Uitgang_Click(object sender, RoutedEventArgs e)
        {

            Teller.Content = counter - 1;
            counter--;

        }
    }
}
