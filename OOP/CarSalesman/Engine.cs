using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, string power)
            : this(model, power, null, "n/a")
        {

        }

        public Engine(string model, string power, int? disp, string eff)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = disp;
            this.Efficiency = eff;
        }
    }
}
