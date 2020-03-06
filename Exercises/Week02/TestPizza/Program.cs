using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new Pizza();
            myPizza.Toppings = "Cheese";
            myPizza.Diameter = 12;
            myPizza.Price = 15.3;
            Console.WriteLine($"Toppings: {myPizza.Toppings}");
            Console.WriteLine($"Diameter: {myPizza.Diameter}");
            Console.WriteLine($"Price: ${myPizza.Price:c}");
        }
    }
}
