using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MordersCrueltyPlan.Foods
{
    public class OtherFood : Food
    {
        public override int Points
        {
            get
            {
                return -1;
            }
        }
    }
}
