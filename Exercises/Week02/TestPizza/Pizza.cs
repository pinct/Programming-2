using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizza
{
    class Pizza
    {
        private string toppings;
        private int diameter;
        private double price;

        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
