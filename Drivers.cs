using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwoMiDa
{
    internal class Drivers
    {
        public string VehicleType()
        {
            Console.WriteLine("Do you drive a keke, okada, korope or big bus? ");
            string vehicle = Console.ReadLine();
            string vvehicle = vehicle.ToLower();
            switch (vvehicle)
            {
                case "keke":
                    return "50";

                case "okada":
                    return "30";
                    
                case "korope":
                    return "100";

                case "big bus":
                    return "200";

                default:
                    Console.WriteLine("Invalid Input");
                    return "0";
            }
        }

        public double Membership()
        {
            string ms = "invalid";
            while((ms != "0") || (ms != "1"))
            {
                Console.WriteLine("If you are a member of the NURTW, type 1. If not, type 0: ");
                ms = Console.ReadLine();
                if ((ms == "0")||(ms=="1"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            if (ms == "0")
            {
                double rate = 1;
                return rate;
            }
            else if (ms == "1")
            {
                double rate = 0.7;
                return rate;

            }
            else
            {
                return 5.0;
            }


        }

        public double TollFee(double rate, int vehicleTypeCharge)
        {
            Console.WriteLine("How many trips did you take today? ");
            int noOfTrips=Convert.ToInt32(Console.ReadLine());

            double tollFee = Convert.ToInt32(vehicleTypeCharge) * noOfTrips * rate;
            return tollFee;            
        }

        public double TotalAmount()
        {
            double Amount = 0;
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Driver " + i + ":");
                double rate = Membership();
                int vehicleTypeCharge = Convert.ToInt32(VehicleType());
                Amount += TollFee(rate,vehicleTypeCharge);
            }
            return Amount;
        }      
   
    }
}
