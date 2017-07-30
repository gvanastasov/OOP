using Encapsulation.PizzaCalories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.PizzaCalories
{
    public class Pizza
    {
        public Pizza(string name, int toppingsCount)
        {
            this.Name = name;
            this.ToppingsCount = toppingsCount;
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

        public Dough dough;

        private List<Topping> toppings;
        public IReadOnlyList<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public int ToppingsCount
        {
            get
            {
                return this.toppings.Count;
            }
            private set
            {
                if(value < 0 || value > 10)
                {
                    throw new Exception("Number of toppings should be in range [0..10].");
                }

                this.toppings = new List<Topping>(value);
            }
        }

        public double TotalCalories
        {
            get
            {
                return dough.GetCalories() + toppings.Sum(t => t.GetCalories());
            }
        }
    }
}
