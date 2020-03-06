using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerSystem
{
    enum Level {Business, Executive, Vip}
    class FirstClass : Passenger
    {
        public const int FIRST_LUGGAGE = 2;
        public Level Level { get; set;}
        public override int CalculateBaggage()
        {
            return base.CalculateBaggage() + FIRST_LUGGAGE;
        }
        public FirstClass(Level level, PointsProgram pointsProgram, bool isCanadian) : base(pointsProgram, isCanadian)
        {
            Level = level;
        }
    }
}
