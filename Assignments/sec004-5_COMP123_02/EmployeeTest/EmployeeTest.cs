using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            //Object Declaration
            Employee employee1 = new Employee(2, "Mike", 40000);
            Employee employee2 = new Employee();

            //Setting Fields for employee2
            Console.Write("First Name: ");
            employee2.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            employee2.LastName = Console.ReadLine();
            Console.Write("Base Salaray: ");
            employee2.BaseSalary = Convert.ToDouble(Console.ReadLine());
            
            while (employee2.GrossSales <= 0)
            {
                Console.Write("Gross Sales: ");
                employee2.GrossSales = Convert.ToDouble(Console.ReadLine());
            }
            
            Console.Write("Comission Rate: ");
            employee2.ComissionRate = Convert.ToDouble(Console.ReadLine());
            
            while (employee2.ComissionRate <= 0 || employee2.ComissionRate >= 1.0)
            {
                Console.Write("Comission Rate: ");
                employee2.ComissionRate = Convert.ToDouble(Console.ReadLine());
            }
            
            //Printing Total Earnings
            Console.WriteLine($"Total Earnings: {employee2.Earnings():c}");
        }
    }
}
