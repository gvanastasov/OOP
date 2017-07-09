using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumption = consumption;
            this.DistanceTraveled = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double DistanceTraveled { get; set; }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }

        public void Drive(double distancce)
        {
            var consumption = FuelConsumption * distancce;

            if(consumption > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= consumption;
                this.DistanceTraveled += distancce;
            }
        }
    }
}
