using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoScouts
{
    class Program
    {
        static void Main(string[] args)
        {
            GirlScout girl1 = new GirlScout();
            GirlScout girl2 = new GirlScout("Taylor", 1025, 10.25);
            Console.WriteLine($"Name: {girl1.Name} Troop: {girl1.TroopNum} Dues: ${girl1.DuesOwed}");
            Console.WriteLine($"Name: {girl2.Name} Troop: {girl2.TroopNum} Dues: ${girl2.DuesOwed}");
            Console.WriteLine($"{girl1.Motto}");
        }
    }
}
