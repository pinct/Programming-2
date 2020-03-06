using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxMath(100.00, 0.06);
            TaxMath(100.00, 6);
        }
        static void TaxMath(double price, double taxRate)
        {
            Console.WriteLine($"Total: ${(price * (taxRate + 1)):f2}");
        }
        static void TaxMath(double price, int taxRate)
        {
            Console.WriteLine($"Total: ${(price * (((double)taxRate/100) + 1)):f2}");
        }
    }
}
