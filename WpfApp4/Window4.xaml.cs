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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        List<Orders> orderList = new List<Orders>();
        public Window4()
        {
            InitializeComponent();
        }

        private void Pancakes_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Breakfast breakfast = new Breakfast();
            Orders Order = new Orders(breakfast.Pancakes, breakfast.PancakesP);

            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Waffles_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Breakfast breakfast = new Breakfast();
            Orders Order = new Orders(breakfast.Waffles, breakfast.WafflesP);

            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Crepes_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Breakfast breakfast = new Breakfast();
            Orders Order = new Orders(breakfast.Crepes, breakfast.CrepesP);
            if(!breakfast.crepeCheck(notesbox.Text))
            {
                    return;
            }
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Omellette_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Breakfast breakfast = new Breakfast();
            Orders Order = new Orders(breakfast.SwOmellete, breakfast.SwOmelleteP);


            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void done_Click(object sender, RoutedEventArgs e)
        { 
            Orders test = new Orders();
            if (!orderList.Any())
            {
                Window win = new Window1();
                win.Show();
                this.Close();
                return;
            }
            Receipt.Text += DateTime.Now.ToString("h:mm:ss tt") + "\n";
            Receipt.Text += "Receipt# " + Convert.ToString(test.GetOrderNumber() + "\n");
            foreach (Orders ordered in orderList)
            {
                Receipt.Text += ordered.Item + "\t    " + ordered.Price + "\n    " + ordered.Note + "\n";   
            }
            Receipt.Text += "Total: " + Convert.ToString(Math.Round(test.getTotal(orderList), 2)) + "\n";
            Receipt.Text += "Tax: " + Convert.ToString(Math.Round(test.getTax(orderList), 2)) + "\n";
            Receipt.Text += "Final: " + Convert.ToString(test.getFinal(orderList)) + "\n";
            test.GetOrderNumber();
            test.Print(Receipt);
            test.saveOrder(orderList);
            Window win1 = new Window1();
            win1.Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selected = new ListBoxItem();
            selected.Content = currentOrder.SelectedItem;
            string item = Convert.ToString(selected.Content);
            string[] items = item.Split();
            int i = 0;
            item = items[1] + " " + items[2];
            while (i < orderList.Count)
            {
                if (orderList[i].Item.Contains(item))
                {
                    orderList.RemoveAt(i);
                    currentOrder.Items.Remove(currentOrder.SelectedItem);
                    return;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
