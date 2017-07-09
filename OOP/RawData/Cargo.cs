using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
        public double Weight { get; set; }
        public CargoType CargoType { get; set; }

        public Cargo(double weight, CargoType type)
        {
            this.Weight = weight;
            this.CargoType = type;
        }
    }
}
