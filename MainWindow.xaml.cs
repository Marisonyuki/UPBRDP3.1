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
using UPBRDP3._1.BRDUPDataSetTableAdapters;

namespace UPBRDP3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameIndustryTableAdapter GI = new GameIndustryTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            BDG.ItemsSource = GI.GetFullData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BDG.Columns[0].Visibility = Visibility.Collapsed;
            BDG.Columns[1].Visibility = Visibility.Collapsed;
            BDG.Columns[2].Visibility = Visibility.Collapsed;
            BDG.Columns[3].Visibility = Visibility.Collapsed;
            BDG.Columns[7].Visibility = Visibility.Collapsed;
        }
    }
}
