using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Moods
{
    public abstract class Mood
    {
        public Mood()
        {
            this.Name = this.GetType().Name;
        }

        public string Name { get; private set; }
        public abstract int PointsLowerBound { get; }
        public abstract int PointUpperBound { get; }
    }
}
