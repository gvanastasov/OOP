using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.FootbalTeamGenerator
{
    public class Stat
    {
        public Stat(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        private int value;

        public int Value
        {
            get { return value; }
            set
            {
                if(value < 0 || value > 100)
                {
                    throw new Exception($"{this.Name} should be between 0 and 100.");
                }
                this.value = value;
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

    }
}
