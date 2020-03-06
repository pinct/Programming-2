using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    class DemoLoan
    {
        static void Main(string[] args)
        {
            Loan myLoan = new Loan(2239, "Mitchel", 1000);
            Console.WriteLine($"Loan #: {myLoan.LoanNumber} for {myLoan.LastName} is {myLoan.LoanAmount:c}");

            CarLoan myCarLoan = new CarLoan(3358, "Jansen", 20000, 2007, "Ford");
            Console.WriteLine($"Loan #: {myCarLoan.LoanNumber} for {myCarLoan.LastName} is {myCarLoan.LoanAmount:c}");
            Console.WriteLine($"Loan #: {myCarLoan.LoanNumber} is for a {myCarLoan.Year} {myCarLoan.Make}");
        }
    }
    class Loan
    {
        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;
        public Loan(int num, string name, double amount)
        {
            LoanNumber = num;
            LastName = name;
            LoanAmount = amount;
        }
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            get
            {
                return loanAmount;
            }
            set
            {
                if (value < MINIMUM_LOAN)
                {
                    loanAmount = MINIMUM_LOAN;
                }
                else
                {
                    loanAmount = value;
                }
            }
        }
    }
    class CarLoan : Loan
    {
        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;
        private int year;
        public CarLoan(int num, string name, double amount, int year, string make) : base(num, name, amount)
        {
            Year = year;
            Make = make;
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                {
                    year = value;
                }
            }
        }
        public string Make { get; set; }
        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if(value < LOWEST_INVALID_NUM)
                {
                    base.LoanNumber = value;
                }
                else
                {
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
                }
            }
        }
    }
}
