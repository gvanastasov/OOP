using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Moods
{
    public class Sad : Mood
    {
        public override int PointsLowerBound
        {
            get
            {
                return -5;
            }
        }

        public override int PointUpperBound
        {
            get
            {
                return 0;
            }
        }
    }
}
