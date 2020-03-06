using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class Employee
    {
        //Fields
        private int employeeId;
        private string firstName;
        private string lastName;
        private double baseSalary;
        private double grossSales;
        private double comissionRate;

        //Parameters
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                baseSalary = value;
            }
        }
        public double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                grossSales = value;
            }
        }
        public double ComissionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                comissionRate = value;
            }
        }

        //Methods
        public double Earnings()
        {
            return (ComissionRate * GrossSales + BaseSalary);
        }

        //Constructors
        public Employee()
        {
            BaseSalary = 1000.00;
            ComissionRate = 0.1;
        }
        public Employee(int employeeID, string firstName, double baseSalary)
        {
            employeeId = employeeID;
            FirstName = firstName;
            BaseSalary = baseSalary;
            ComissionRate = 0.1;
        }
    }
}
