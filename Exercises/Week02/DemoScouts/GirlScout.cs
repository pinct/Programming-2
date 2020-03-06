using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoScouts
{
    class GirlScout
    {
        private string name;
        private int troopNum;
        private double duesOwed;
        private static string motto = "to Obey the Girl Scout law.";

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
        public int TroopNum
        {
            get
            {
                return troopNum;
            }
            set
            {
                troopNum = value;
            }
        }
        public double DuesOwed
        {
            get
            {
                return duesOwed;
            }
            set
            {
                duesOwed = value;
            }
        }
        public string Motto
        {
            get
            {
                return motto;
            }
        }

        public GirlScout()
        {
            Name = "Unknown";
            TroopNum = 0;
            DuesOwed = 0;
        }
        public GirlScout(string name, int troop, double dues)
        {
            Name = name;
            TroopNum = troop;
            DuesOwed = dues;
        }
    }
}
