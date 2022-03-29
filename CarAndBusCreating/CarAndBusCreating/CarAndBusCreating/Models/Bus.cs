using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndBusCreating.Models
{
    class Bus:Car
    {
        public int PassengerCount;

        public Bus(int passengerCount, string brand, string model, string color, int maxSpeed) : base(brand, model, color, maxSpeed)
        {
            Console.WriteLine("Bus was created.");
            this.PassengerCount = passengerCount;
        }

        public override string InfoAll()
        {
            return base.InfoAll() + ", Passenger count: " + PassengerCount;
        }
        
    }
}
