using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Dinner : Orders
    {
        //lunch
        private static string burger = "Cheese Burger";
        private static double burgerP = 9.99;

        private static string cknFingers = "Chicken Fingers";
        private static double cknFingersP = 10.99;

        private static string cknSand = "Chicken Sandwich";
        private static double cknSandP = 10.99;

        private static string sands = "Soup and Salad";
        private static double sandsP = 7.99;
        //Dinner
        private static string steak = "Ribeye Steak";
        private static double steakP = 14.99;

        private static string salmon = "Grilled Salmon";
        private static double salmonP = 14.99;

        private static string caesarSal = "Chicken Caesar Salad";
        private static double caesarSalP = 10.99;

        private static string chicken = "Grillen Chicken";
        private static double chickenP = 10.99;

        private static DateTime lunchHours = Convert.ToDateTime("10:30:00 AM");
        //Lunch
        public DateTime LunchHours
        {

            get
            {
                return lunchHours;
            }
        }
        public string Burger
        {
            get
            {
                return burger;
            }
        }
        public double BurgerP
        {
            get
            {
                return burgerP;
            }
        }
        public string CknFingers
        {
            get
            {
                return cknFingers;
            }
        }
        public double CknFingersP
        {
            get
            {
                return cknFingersP;
            }
        }
        public string CknSand
        {
            get
            {
                return cknSand;
            }
        }
        public double CknSandP
        {
            get
            {
                return cknSandP;
            }
        }
        public string SoupandSalad
        {
            get
            {
                return sands;
            }
        }
        public double SoupandSaladP
        {
            get
            {
                return sandsP;
            }
        }

        //Dinner
        public string Steak
        {
            get
            {
                return steak;
            }
        }
        public double SteakP
        {
            get
            {
                return steakP;
            }
        }
        public string Salmon
        {
            get
            {
                return salmon;
            }
        }
        public double SalmonP
        {
            get
            {
                return salmonP;
            }
        }
        public string CaesarSal
        {
            get
            {
                return caesarSal;
            }
        }
        public double CaesarSalP
        {
            get
            {
                return caesarSalP;
            }
        }
        public string Chicken
        {
            get
            {
                return chicken;
            }
        }
        public double ChickenP
        {
            get
            {
                return chickenP;
            }
        }
        public bool checkHours()
        {
            if (DateTime.Compare(DateTime.Now, LunchHours) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
