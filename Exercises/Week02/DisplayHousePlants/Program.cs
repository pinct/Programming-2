using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayHousePlants
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePlant plant1 = new HousePlant();
            HousePlant plant2 = new HousePlant();
            HousePlant plant3 = new HousePlant();
            plant1.Name = "Daffodil";
            plant1.Price = 2.3;
            plant1.FedRecently = true;
            plant2.Name = "Daisy";
            plant2.Price = 1.7;
            plant2.FedRecently = false;
            plant3.Name = "Lilac";
            plant3.Price = 2.93;
            plant3.FedRecently = true;
            Console.WriteLine($"Plant: {plant1.Name}  Price: ${plant1.Price:C}  Needs Water: {plant1.FedRecently}");
            Console.WriteLine($"Plant: {plant2.Name}  Price: ${plant2.Price:C}  Needs Water: {plant2.FedRecently}");
            Console.WriteLine($"Plant: {plant3.Name}  Price: ${plant3.Price:C}  Needs Water: {plant3.FedRecently}");
        }
    }
}
