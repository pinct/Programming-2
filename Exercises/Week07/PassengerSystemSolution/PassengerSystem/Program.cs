using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //regular passenger
            Passenger regularPassenger = new Passenger(PointsProgram.NoProgram, true);
            regularPassenger.Name = "Aderson Oliveira";
            regularPassenger.Address = "2000 Yonge Street";
            regularPassenger.Passport = "NG56743";
            regularPassenger.DateOfBirth = "Oct/01/1990";

            Console.WriteLine("REGULAR PASSENGER");
            Console.WriteLine("------------------");
            Console.WriteLine(regularPassenger.ToString());

            Console.WriteLine("");

            //first-class passenger
            FirstClass firstClassPassenger = new FirstClass(Level.Business, PointsProgram.AirMiles, false);
            firstClassPassenger.Name = "Jason Smith";
            firstClassPassenger.Address = "45 Apple Road";
            firstClassPassenger.Passport = "YU76545";
            firstClassPassenger.DateOfBirth = "Jan/04/2001";

            Console.WriteLine("FIRST-CLASS PASSENGER");
            Console.WriteLine("---------------------");
            Console.WriteLine(firstClassPassenger.ToString());

            FileStream outfile = new FileStream("Passengers.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(outfile);
            streamWriter.WriteLine(JsonConvert.SerializeObject(firstClassPassenger));
            streamWriter.Close();
            outfile.Close();
        }
    }
}
