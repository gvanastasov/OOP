using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Moods
{
    public class Happy : Mood
    {
        public override int PointsLowerBound
        {
            get
            {
                return 1;
            }
        }

        public override int PointUpperBound
        {
            get
            {
                return 2;
            }
        }
    }
}
