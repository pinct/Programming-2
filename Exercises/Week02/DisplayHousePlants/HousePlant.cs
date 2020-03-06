using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayHousePlants
{
    class HousePlant
    {
        private string name;
        private double price;
        private bool fedRecently;
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
        public bool FedRecently
        {
            get
            {
                return fedRecently;
            }
            set
            {
                fedRecently = value;
            }
        }
    }
}
