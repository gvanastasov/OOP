using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Moods
{
    public class Angry : Mood
    {
        public override int PointsLowerBound
        {
            get
            {
                return int.MinValue;
            }
        }

        public override int PointUpperBound
        {
            get
            {
                return -5;
            }
        }
    }
}
