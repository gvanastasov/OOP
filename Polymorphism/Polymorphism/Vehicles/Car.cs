using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override string Drive(double distance)
        {
            var requiredFuel = distance * (this.FuelConsumption + 0.9f);

            if (requiredFuel < this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
    }
}
