using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override string Drive(double distance)
        {
            var requiredFuel = distance * (this.FuelConsumption + 1.6f);

            if(requiredFuel < this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled 10 km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
