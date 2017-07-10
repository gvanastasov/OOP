using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; private set; }

        public Car(string[] args)
        {
            this.Model = args[0];

            this.Engine = new Engine(int.Parse(args[1]), int.Parse(args[2]));
            this.Cargo = new Cargo(double.Parse(args[3]), (args[4] == "fragile" ? CargoType.fragile : CargoType.flamable));

            this.Tires = new Tire[4];
            for (int i = 0, j = 5; i < 4; i++, j+=2)
            {
                this.Tires[i] = new Tire(double.Parse(args[j]), int.Parse(args[j+1]));
            }
        }

        public bool HasFlatTire
        {
            get
            {
                return Tires.Any(t => t.Pressure < 1);
            }
        }

        public bool HasBigEngine
        {
            get
            {
                return Engine.Power > 250;
            }
        }
    }
}
