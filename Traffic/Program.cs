using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void AddPassenger(IPassengerCarrier carrier)
        {
            carrier.LoadPassenger();
            if (carrier.GetType() == typeof(Vehicle))
            {
                Console.WriteLine(carrier.ToString());
            }
        }
    }
}
