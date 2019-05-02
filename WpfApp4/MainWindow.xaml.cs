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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int num;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Place_Click(object sender, RoutedEventArgs e)
        {
            Window win1 = new Window1();
            win1.Show();
            this.Hide();//this left on for clarification
        }

        private void Recent_Click(object sender, RoutedEventArgs e)
        {
            Window win2 = new Window2();
            win2.Show();
            this.Close();
            //this will open a new window and display recent orders
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
