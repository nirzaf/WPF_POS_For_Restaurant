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
using System.Windows.Shapes;
using System.IO;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
      
        public Window2()
        {
            InitializeComponent();
            LoadOrders();
        }
        public void LoadOrders()
        {
            

            Orders test = new Orders();
            int orderCount = 0;
            string filePath = @"Assets\Orders";
            orderCount = test.GetOrderNumber();

            for (int i = 1; i < orderCount; i++)
            {
                ListBoxItem recentOrder = new ListBoxItem();
                filePath = @"Assets\Orders\Order" + Convert.ToString(i) + ".txt";
                string recent = test.LoadRecents(filePath);
                recentOrder.Content = recent;
                recentOrdersList.Items.Add(recentOrder);
            }
            return;
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            Window main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void recentOrdersList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            viewOrder.Items.Clear();
            ListBoxItem item = new ListBoxItem();

            item.Content = recentOrdersList.SelectedItem.ToString();
            viewOrder.Items.Add(item);
        }
    }
}
