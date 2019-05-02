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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        


     
        public Window1()
        {
            InitializeComponent();
        }
        

        private void dinner_Click(object sender, RoutedEventArgs e)
        {
            Dinner test = new Dinner();

            if (test.checkHours())//if current time is earlier than breakfast hours open breakfast menu
            {
                Window win3 = new Window3();
                win3.Show();
                this.Hide();//THIS keyword is not needed but helps me think what is happening
            }
            else//even if its 11am breakfast will no longer be served
            {
                MessageBox.Show("It is not lunch time yet");
                return;
            }

      
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Window main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void breakfast_Click(object sender, RoutedEventArgs e)
        {
   
            Breakfast breakfast = new Breakfast();
            

            if(breakfast.hoursCheck())//if current time is earlier than breakfast hours open breakfast menu
            {
                Window win4 = new Window4();
                win4.Show();
                this.Hide();//THIS keyword is not needed but helps me think what is happening
            }
            else//even if its 11am breakfast will no longer be served
            {
                MessageBox.Show("Breakfast hours are over");
                return;
            }
            
        }
    }
}
