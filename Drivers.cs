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
            string? vehicle = Console.ReadLine();
            switch (vehicle.ToLower())
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
                ms = Console.ReadLine().ToLower();
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
            else
            {
                double rate = 0.7;
                return rate;

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
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Driver {0} : ", i+1);
                double rate = Membership();
                int vehicleTypeCharge = Convert.ToInt32(VehicleType());
                int tollFee = Convert.ToInt32(TollFee(rate, vehicleTypeCharge));
                Console.WriteLine("The Toll fee for driver {0} is {1} \n",i+1, tollFee);
                Amount += tollFee;
            }
            return Amount;
        }      
   
    }
}
