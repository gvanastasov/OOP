using Inheritance.MordersCrueltyPlan.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan
{
    public static class FoodFactory
    {
        public static Food Get(string foodname)
        {
            var type = typeof(Food).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Food))).FirstOrDefault(t => t.Name.ToLower() == foodname.ToLower());

            if(type != null)
            {
                return Activator.CreateInstance(type) as Food;
            }
            else
            {
                return Activator.CreateInstance(typeof(OtherFood)) as Food;
            }
        }
    }
}
