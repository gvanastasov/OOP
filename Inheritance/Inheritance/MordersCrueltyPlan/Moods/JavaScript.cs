using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Moods
{
    public class JavaScript : Mood
    {
        public override int PointsLowerBound
        {
            get
            {
                return 15;
            }
        }

        public override int PointUpperBound
        {
            get
            {
                return int.MaxValue;
            }
        }
    }
}
