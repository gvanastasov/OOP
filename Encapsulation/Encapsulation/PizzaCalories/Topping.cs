using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation.PizzaCalories.Enums;

namespace Encapsulation.PizzaCalories
{
    public class Topping
    {
        public const int BASE_CALORIES = 2;

        public Topping(string type, int weight)
        {
            type = type.First().ToString().ToUpper() + type.Substring(1).ToLower();

            if (Enum.TryParse(type, out this.toppingType) == false)
            {
                throw new Exception($"Cannot place {type} on top of your pizza.");
            }
            this.Weight = weight;
        }

        private ToppingType toppingType;
        public ToppingType ToppingType
        {
            get
            {
                return this.toppingType;
            }
            set
            {
                this.toppingType = value;
            }
        }

        private int weight;
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new Exception($"{this.ToppingType} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private double CalculateCaloriesPerGram()
        {
            double calories = BASE_CALORIES;

            switch (ToppingType)
            {
                case ToppingType.Meat:
                    calories *= 1.2f;
                    break;
                case ToppingType.Veggies:
                    calories *= 0.8f;
                    break;
                case ToppingType.Cheese:
                    calories *= 1.1f;
                    break;
                case ToppingType.Sauce:
                    calories *= 0.9f;
                    break;
            }

            return calories;
        }

        public double GetCalories()
        {
            return CalculateCaloriesPerGram() * this.Weight;
        }
    }
}
