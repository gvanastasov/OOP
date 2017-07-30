using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Animals.Enums;

namespace Inheritance.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender) : base(name, age, gender)
        {
            this.Gender = Gender.Female;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
