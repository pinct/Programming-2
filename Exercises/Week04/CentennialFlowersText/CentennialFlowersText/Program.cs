using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentennialFlowersText
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteOrder();
            ReadOrder();

        }
        static void WriteOrder()
        {
            FileStream outFile = new FileStream("Orders.txt",
                FileMode.Create,
                FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(outFile);

            Order orderOne = new Order();
            Console.WriteLine("How many orders?");
            int num = int.Parse(Console.ReadLine());
            for (int i=0; i < num; i++)
            {
                Console.WriteLine($"Enter the Details of the Order {i + 1}");

                Console.Write(" - Order Number: ");
                orderOne.OrderNumber = int.Parse(Console.ReadLine());

                Console.Write(" - Customer Name: ");
                orderOne.CustomerName = Console.ReadLine();

                Console.Write(" - Arrangement: ");
                orderOne.Arrangement = Console.ReadLine();

                Console.Write(" - Quantity: ");
                orderOne.Quantity = int.Parse(Console.ReadLine());

                Console.Write(" - Unit Price: ");
                orderOne.UnitPrice = double.Parse(Console.ReadLine());

                streamWriter.WriteLine($"{orderOne.OrderNumber},{orderOne.CustomerName},{orderOne.Arrangement},{orderOne.Quantity},{orderOne.UnitPrice}");
            }
            streamWriter.Close();
            outFile.Close();
        }
        static void ReadOrder()
        {
            double total = 0;
            int num = 0;
            FileStream inFile = new FileStream("Orders.txt",
                FileMode.Open,
                FileAccess.Read);

            StreamReader streamReader = new StreamReader(inFile);
            Order orderOne = new Order();
            string reading = streamReader.ReadLine();
            while (reading != null)
            {
                string[] orders = reading.Split(',');
                orderOne.OrderNumber = int.Parse(orders[0]);
                orderOne.CustomerName = orders[1];
                orderOne.Arrangement = orders[2];
                orderOne.Quantity = int.Parse(orders[3]);
                orderOne.UnitPrice = double.Parse(orders[4]);

                Console.WriteLine("------------------------");
                Console.WriteLine($"Order {num+1} Information");
                Console.WriteLine("------------------------");
                Console.WriteLine($"Order Number: {orderOne.OrderNumber}");
                Console.WriteLine($"Customer Name: {orderOne.CustomerName}");
                Console.WriteLine($"Arrangement: {orderOne.Arrangement}");
                Console.WriteLine($"Quantity: {orderOne.Quantity}");
                Console.WriteLine($"Unity Price: {orderOne.UnitPrice:c}");
                Console.WriteLine($"Total Price: {orderOne.TotalPrice:c}");
                total = total + orderOne.TotalPrice;
                num++;

                reading = streamReader.ReadLine();
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"Total Number of Orders: {num}");
            Console.WriteLine($"Grand Total Price: {total:c}");
            streamReader.Close();
            inFile.Close();
        }
            
    }
}
