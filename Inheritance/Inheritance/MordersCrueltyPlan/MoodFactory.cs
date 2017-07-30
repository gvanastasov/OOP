using Inheritance.MordersCrueltyPlan.Moods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan
{
    public static class MoodFactory
    {
        public static Mood Get(int points)
        {
            Type type;

            if(points < -5)
            {
                type = typeof(Angry);
            }
            else if(points < 0)
            {
                type = typeof(Sad);
            }
            else if(points < 15)
            {
                type = typeof(Happy);
            }
            else
            {
                type = typeof(JavaScript);
            }

            return Activator.CreateInstance(type) as Mood;
        }
    }
}
