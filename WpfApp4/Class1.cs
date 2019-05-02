using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;
namespace WpfApp4
{
    
    class Orders
    {
        private string recent;
        private string item;
        private double price = 0;
        private double tax;
        private double totalPrice = 0;
        private string notes;  //use this for things like -no lettuce, no tomato such special notes
        private int orderNumber;
        private static double taxRate = .1;

        public Orders()
        {
        }
        public Orders(string name, double price)
        {
            Item = name;
            Price = price;
        }
        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }
            set
            {
                orderNumber = value;
            }
        }
        public string Item
        {
            set
            {
                this.item = value;
            }
            get
            {
                return item;
            }
        }
        public string Recent
        {
            set
            {
                this.recent = value;
            }
            get
            {
                return recent;
            }
        }
        public double Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return price;
            }
        }
        public double Tax
        {
            set
            {
                this.tax = TotalPrice * .10;
            }
            get
            {
                return tax;
            }
        }
        public string Note
        {
            set
            {
                this.notes = value;
            }
            get
            {
                return notes;
            }
        }
        public double TotalPrice
        {
            set
            {
                this.totalPrice = value;
            }
            get
            {
                return totalPrice;
            }
        }
       
       public void saveOrder( List<Orders> order)
        {
            string filePath = @"Assets\Orders\Order" + Convert.ToString(OrderNumber)+".txt";
            double stotal = Math.Round(getTotal(order), 2);
            double tax = Math.Round(getTax(order), 2);
            double total = tax + stotal;
            using(StreamWriter fileStream = new StreamWriter(filePath))
            {
                fileStream.WriteLine(DateTime.Now + "\n");
                fileStream.WriteLine("Receipt# " + OrderNumber + "\n");
                foreach(Orders ordered in order)
                {
                    fileStream.WriteLine(ordered.item + " " + ordered.price + "\n" + ordered.Note);
                }
                fileStream.WriteLine("Subtotal: " + stotal);
                fileStream.WriteLine("Tax: " + tax);
                fileStream.WriteLine("Total: " + total);
                fileStream.Close();
            }
            
            return;
        }
       public double getTax(List<Orders> Order)
        {
            double total = 0;
            double tax = 0;
            foreach(Orders ordered in Order)
            {
                total += ordered.price;
            }
            return tax = (total * taxRate);
        }
        public double getTotal(List<Orders> Order)
        {
            double total = 0;
            foreach(Orders ordered in Order)
            {
                total += ordered.price;
            }
            return total;
        }
        public double getFinal(List<Orders> Order)
        {
            double total = getTotal(Order);
            double tax = getTax(Order);
            return Math.Round(tax + total, 2);
        }
        public int GetOrderNumber()
        {
            string path = @"Assets\Orders\";
            int orderCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
            OrderNumber = orderCount + 1;
            return orderCount + 1;

        }
        public string LoadRecents(string path)
        {
            
                using (StreamReader fileStream = new StreamReader(path))
                {
                    Recent = fileStream.ReadToEnd();
                }
                return Recent;
            
           
        }

        public void Print(TextBlock Receipt)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(Receipt, " Printing");
            }
            return;
        }
    }
}
