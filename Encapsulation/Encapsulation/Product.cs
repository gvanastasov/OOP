using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        private decimal cost;
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Cost cannot be negative.");
                }

                this.cost = value;
            }
        }
    }
}
