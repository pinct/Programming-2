using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        private string name;
        private double salesAmount;
        private double commission;
        private double commissionRate;
        private enum Status {InProgress, Pending, Paid};
        private Status SalesStatus;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double SalesAmount
        {
            get
            {
                return salesAmount;
            }
            set
            {
                salesAmount = value;
            }
        }
        public double Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
        }
        public static double SalesTarget
        {
            get
            {
                return SalesTarget;
            }
            set
            {
                SalesTarget = value;
            }
        }
        public SalesTransaction(string name, double salesAmount, double commissionRate)
        {
            Name = name;
            SalesAmount = salesAmount;
            this.commissionRate = commissionRate;
            Commission = salesAmount * CommissionRate;
            SalesStatus = Status.InProgress;
        }
        public SalesTransaction(string name, double salesAmount)
        {
            Name = name;
            SalesAmount = salesAmount;
            commissionRate = 0;
            Commission = CommissionRate * SalesAmount;
            SalesStatus = Status.InProgress;
        }
        public SalesTransaction(string name)
        {
            Name = name;
            SalesAmount = 0;
            commissionRate = 0;
            Commission = SalesAmount * CommissionRate;
            SalesStatus = Status.InProgress;
        }
        private SalesTransaction()
        {
            commissionRate = 0.10;
        }
        static SalesTransaction()
        {
            SalesTarget = 1000;
        }
        public string ToString()
        {
            return $"Sales Person Name: {Name} –Commission: {Commission:c}";
        }
    }
}
