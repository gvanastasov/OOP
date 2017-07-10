using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $@"
{Model}:
    {Engine.Model}:
        Power:{Engine.Power}
        Displacement:{(Engine.Displacement.HasValue ? Engine.Displacement.Value.ToString() : "n/a")}
        Efficiency:{Engine.Efficiency}
    Weight:{(this.Weight.HasValue ? this.Weight.Value.ToString() : "n/a")}
    Color:{(string.IsNullOrEmpty(this.Color) ? "n/a" : this.Color)}";
        }
    }
}
