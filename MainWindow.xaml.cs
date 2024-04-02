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
using PrPract3.DataSet1TableAdapters;

namespace PrPract3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConnectIdTableAdapter connectid = new ConnectIdTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            tablic.ItemsSource = connectid.GetFullInfo();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tablic.Columns[0].Visibility = Visibility.Collapsed;
            tablic.Columns[1].Visibility = Visibility.Collapsed;
            tablic.Columns[2].Visibility = Visibility.Collapsed;
            tablic.Columns[3].Visibility = Visibility.Collapsed;
        }
    }
}
