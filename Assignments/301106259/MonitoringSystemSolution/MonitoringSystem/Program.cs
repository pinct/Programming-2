using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //residential client
            Client residentialCustomer = new Client(Service.Sensors, 4);
            residentialCustomer.Name = "John Smith";
            residentialCustomer.Address = "12 Main Street";
            residentialCustomer.Phone = "123-456-7890";

            Console.WriteLine("RESIDENTIAL CLIENT");
            Console.WriteLine("------------------");
            Console.WriteLine(residentialCustomer.ToString());
            Console.WriteLine($"- With 20% discount, the new price is {residentialCustomer.CalculatePrice(20):c} per month");

            residentialCustomer.SaveData("residentialCustomer.json");
            Console.WriteLine("");

            //business client
            Business businessCustomer = new Business(BusinessType.Office, Service.Intercoms, 5);
            businessCustomer.Name = "Lawyers & Lawyers";
            businessCustomer.Address = "34 Busy Plaza Road";
            businessCustomer.Phone = "987-456-1234";

            Console.WriteLine("COMMERCIAL CLIENT");
            Console.WriteLine("------------------");
            Console.WriteLine(businessCustomer.ToString());
            Console.WriteLine($"- With 10% discount, the new price is {businessCustomer.CalculatePrice(10):c} per month");

            businessCustomer.SaveData("businessCustomer.json");
        }
    }
}
