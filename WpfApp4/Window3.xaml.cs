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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        List<Orders> orderList = new List<Orders>();
       
        public Window3()
        {
            InitializeComponent();
        }

        private void Steak_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner dinner = new Dinner();
            Orders Order = new Orders(dinner.Steak, dinner.SteakP);

            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Salmon_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner dinner = new Dinner();
            Orders Order = new Orders(dinner.Salmon, dinner.SalmonP);

            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Chicken_Caesar_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner dinner = new Dinner();
            Orders Order = new Orders(dinner.CaesarSal, dinner.CaesarSalP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Chicken_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner dinner = new Dinner();
            Orders Order = new Orders(dinner.Chicken, dinner.ChickenP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }
       
        private void Burger_Click(object sender, RoutedEventArgs e)
        {
            Dinner lunch = new Dinner();
            ListBoxItem mealItem = new ListBoxItem();
            Orders Order = new Orders(lunch.Burger, lunch.BurgerP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void ChickenSand_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner lunch = new Dinner();
            Orders Order = new Orders(lunch.CknSand, lunch.CknSandP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item +  " \t    " + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;
        }

        private void Chicken_fingers_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner lunch = new Dinner();
            Orders Order = new Orders(lunch.CknFingers, lunch.CknFingersP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + "\t" + Order.Price + "\n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            return;

        }

        private void SandS_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem mealItem = new ListBoxItem();
            Dinner lunch = new Dinner();
            Orders Order = new Orders(lunch.SoupandSalad, lunch.SoupandSaladP);
            Order.Note = notesbox.Text;
            mealItem.Content = Order.Item + " \t  " + Order.Price + "    \n    " + Order.Note + "\n";
            currentOrder.Items.Add(mealItem);
            orderList.Add(Order);
            notesbox.Text = null;
            //return;

        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            Orders test = new Orders();
            //Populate Receipt Visual
            if (!orderList.Any())
            {
                Window win = new Window1();
                win.Show();
                this.Close();
                return;
            }
            Receipt.Text += DateTime.Now.ToString("h:mm:ss tt") + "\n" + "\n";
            Receipt.Text += "Receipt# " +  Convert.ToString(test.GetOrderNumber() + "\n" + "\n");
            foreach (Orders ordered in orderList)
            {
                Receipt.Text += ordered.Item + "\t    " + ordered.Price + "\n    " + ordered.Note + "\n";
            }
            Receipt.Text += "Total: " + Convert.ToString(Math.Round(test.getTotal(orderList), 2)) + "\n";
            Receipt.Text += "Tax: " + Convert.ToString(Math.Round(test.getTax(orderList), 2)) + "\n";
            Receipt.Text += "Final: " + Convert.ToString(test.getFinal(orderList)) + "\n";
           
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
