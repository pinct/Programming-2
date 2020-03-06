using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransactionApp
    {
        static void Main(string[] args)
        {
            SalesTransaction SalesMan1 = new SalesTransaction("John", 300, 0.20);
            SalesTransaction SalesMan2 = new SalesTransaction("Mike", 4);
            SalesTransaction SalesMan3 = new SalesTransaction("Neo");

            Console.WriteLine($"Sales Person Name: {SalesMan1.Name} –Commission: {SalesMan1.Commission:c}");
            Console.WriteLine($"Sales Person Name: {SalesMan2.Name} –Commission: {SalesMan2.Commission:c}");
            Console.WriteLine($"Sales Person Name: {SalesMan3.Name} –Commission: {SalesMan3.Commission:c}");
            Console.WriteLine(SalesMan1.ToString());
        }
    }
}
