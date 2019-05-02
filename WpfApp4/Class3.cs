using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    class Breakfast : Orders
    {
        private static string pancakes = "Buttermilk Pancakes";
        private static double pancakesP = 7.99;

        private static string swOmellete = "Southwest Omellete";
        private static double swOmelleteP = 8.99;

        private static string waffles = "Swedish Waffles";
        private static double wafflesP = 9.99;

        private static string crepes = "Custom Crepes";
        private static double crepesP = 10.99;

        private static DateTime breakFastHours = Convert.ToDateTime("10:30:00 AM");

        public Breakfast()
        {
        }
        public Breakfast(string name, double price) : base(name, price)
        {
        }

        public DateTime BreakFastHours
        {
           
            get
            {
                return breakFastHours;
            }
        }
        public string SwOmellete
        {
            get
            {
                return swOmellete;
            }
        }

        public double SwOmelleteP
        {
            get
            {
                return swOmelleteP;
            }
        }

        public string Pancakes
        {
            get
            {
                return pancakes;
            }
        }

        public double PancakesP
        {
            get
            {
                return pancakesP;
            }
        }

        public string Waffles
        {
            get
            {
                return waffles;
            }
        }

        public double WafflesP
        {
            get
            {
                return wafflesP;
            }
        }

        public string Crepes
        {
            get
            {
                return crepes;
            }
        }

        public double CrepesP
        {
            get
            {
                return crepesP;
            }
        }

        public bool hoursCheck()
        {
            if(DateTime.Compare(DateTime.Now, BreakFastHours) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool crepeCheck(string notes)
        {
            
            if (string.IsNullOrWhiteSpace(notes))
            {
                MessageBox.Show("Please enter what kind of crepes into the notes box\n" + " - Chocolate\n" + " - Banana\n" + " - Strawberry\n" + " - Chicken\n");
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
}
