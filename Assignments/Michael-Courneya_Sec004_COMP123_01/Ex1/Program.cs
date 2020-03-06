using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max of 2 and 4 is: {Maximum(2, 4)}");
            Console.WriteLine($"Max of 2, 4, and 3 is: {Maximum(2, 4, 3)}");
            Console.WriteLine($"Square of 2 is: {Square(2)}");
            Console.WriteLine($"Square of 2.5 is: {Square(2.5)}");
        }
        private static int Maximum(int int1, int int2)
        {
            if(int1 > int2)
            {
                return int1;
            }
            else
            {
                return int2;
            }
        }
        private static int Maximum(int int1, int int2, int int3)
        {
            if(int1 > int2)
            {
                if (int1 > int3)
                {
                    return int1;
                }
                else
                {
                    return int3;
                }
            }
            else if(int2 > int3)
            {
                return int2;
            }
            else
            {
                return int3;
            }
        }
        private static int Square(int num)
        {
            return num * num;
        }
        private static double Square(double num)
        {
            return num * num;
        }
    }
}
