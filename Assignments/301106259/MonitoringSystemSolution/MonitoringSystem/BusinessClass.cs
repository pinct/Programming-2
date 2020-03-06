using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringSystem
{
    enum BusinessType { Store, Office, ApartmentBuilding, Government};
    class Business : Client
    {
        public const int STORE_CHARGE = 2;
        public const int OFFICE_CHARGE = 4;
        public const int APARTMENT_CHARGE = 7;
        public const int GOVERNMENT_CHARGE = 9;

        private BusinessType businessType;

        public BusinessType BusinessType
        {
            get
            {
                return businessType;
            }
            set
            {
                businessType = value;
            }
        }

        public Business(BusinessType businessType, Service service, int quantity) : base(service, quantity)
        {
            BusinessType = businessType;
        }

        public override double CalculatePrice()
        {
            double price = base.CalculatePrice();
            switch (BusinessType)
            {
                case BusinessType.Store:
                    price += STORE_CHARGE;
                    break;
                case BusinessType.Office:
                    price += OFFICE_CHARGE;
                    break;
                case BusinessType.ApartmentBuilding:
                    price += APARTMENT_CHARGE;
                    break;
                case BusinessType.Government:
                    price += GOVERNMENT_CHARGE;
                    break;
            }
            return price;
        }
    }
}
