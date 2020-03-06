using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerSystem
{
    enum PointsProgram { NoProgram, AirMiles, AeroPlan, SkyMiles, MileagePlus, Other };
    class Passenger
    {
        public const int LUGGAGE = 1;
        public const int AIR_LUGGAGE = 1;
        public const int AERO_LUGGAGE = 2;

        private string address;
        private string dateOfBirth;
        private bool isCanadian;
        private string name;
        private string passport;
        private PointsProgram pointsProgram;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return address;
            }
            set
            {
                dateOfBirth = value;
            }
        }
        public bool IsCanadian
        {
            get
            {
                return isCanadian;
            }
            set
            {
                isCanadian = value;
            }
        }
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
        public string Passport
        {
            get
            {
                return passport;
            }
            set
            {
                passport = value;
            }
        }
        public PointsProgram PointsProgram
        {
            get
            {
                return pointsProgram;
            }
            set
            {
                pointsProgram = value;
            }
        }

        public virtual int CalculateBaggage()
        {
            if ((int)PointsProgram == 1)
            {
                return LUGGAGE + AIR_LUGGAGE;
            }
            else if ((int)PointsProgram == 3)
            {
                return LUGGAGE + AERO_LUGGAGE;
            }
            else
            {
                return LUGGAGE;
            }
        }
        public Passenger(PointsProgram pointsProgram, bool isCanadian)
        {
            PointsProgram = pointsProgram;
            IsCanadian = isCanadian;
        }
        public override string ToString()
        {
            return $"- {Name} has passport #{Passport}, lives at {Address} and is allowed to carry {CalculateBaggage()} luggage(s)";
        }
    }
}
