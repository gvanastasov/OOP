using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation.PizzaCalories.Enums;

namespace Encapsulation.PizzaCalories
{
    public class Dough
    {
        public Dough(string flourType, string backingType, int weight)
        {
            flourType = flourType.First().ToString().ToUpper() + flourType.Substring(1).ToLower();
            backingType = backingType.First().ToString().ToUpper() + backingType.Substring(1).ToLower();

            if (Enum.TryParse(flourType, out this.flourType) == false)
            {
                throw new Exception("Invalid type of dough.");
            }

            if (Enum.TryParse(backingType, out this.backingTechniqueType) == false)
            {
                throw new Exception("Invalid type of dough.");
            }

            this.Weight = weight;
        }

        public const int BASE_CALORIES = 2;

        private FlourType flourType;
        public FlourType FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                this.flourType = value;
            }
        }

        private BakingTechniqueType backingTechniqueType;
        public BakingTechniqueType BackingTechniqueType
        {
            get
            {
                return this.backingTechniqueType;
            }
            set
            {
                this.backingTechniqueType = value;
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
                if(value < 0 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private double CaloriesPerGram()
        {
            double calories = BASE_CALORIES;

            switch (BackingTechniqueType)
            {
                case BakingTechniqueType.Crispy:
                    calories *= 0.9f;
                    break;
                case BakingTechniqueType.Chewy:
                    calories *= 1.1f;
                    break;
                case BakingTechniqueType.Homemade:
                    calories *= 1.0f;
                    break;
            }

            switch (FlourType)
            {
                case FlourType.White:
                    calories *= 1.5f;
                    break;
                case FlourType.Wholegrain:
                    calories *= 1.0f;
                    break;
            }

            return calories;
        }

        public double GetCalories()
        {
            return CaloriesPerGram() * this.Weight;
        }
    }
}
