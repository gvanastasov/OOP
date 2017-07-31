using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuel, double consumption)
        {
            this.FuelQuantity = fuel;
            this.FuelConsumption = consumption;
        }

        protected double fuelQuantity;
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                // cannot travel the distance
                if(value < 0)
                {
                    return;
                }

                this.fuelQuantity = value;
            }
        }

        protected double fuelConsumption;
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public abstract string Drive(double distance);
        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
