using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Foods
{
    public abstract class Food
    {
        public Food()
        {
            this.Name = this.GetType().Name;
        }

        public string Name { get; private set; }
        public abstract int Points { get; }
    }
}
