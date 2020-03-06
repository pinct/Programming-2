using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The sum of 3, 4, and 5 is: {Addition(3, 4, 5)}");
            Console.WriteLine($"The sum of 3, 4, 6, and 5 is: {Addition(3, 4, 6, 5)}");
            Console.WriteLine($"The sum of 3, 4, 6, 7, and 5 is: {Addition(3, 4, 6, 7, 5)}");
            Console.WriteLine($"The name is:");
            DisplayNames("Michael");
            Console.WriteLine($"The names are:");
            DisplayNames("Michael", "Aderson");
            Console.WriteLine($"The names are:");
            DisplayNames("Michael", "Aderson", "Neo");
            Console.WriteLine($"The names are:");
            DisplayNames("Michael", "Aderson", "Neo", "Dorothy");
        }
        private static int Addition(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }
        private static void DisplayNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}
