using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            Console.WriteLine($"Before num1 = {num1} and num2 = {num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"After num1 = {num1} and num2 = {num2}");
            int int1;
            int int2;
            Initialize(out int1, out int2);
            Console.WriteLine($"Average of {int1} and {int2} is {(int1 + int2) / 2}");
        }
        private static void Swap(ref int int1, ref int int2)
        {
            int temp = int1;
            int1 = int2;
            int2 = temp;
        }
        private static void Initialize(out int int1, out int int2)
        {
            int1 = 4;
            int2 = 2;
        }
    }
}
