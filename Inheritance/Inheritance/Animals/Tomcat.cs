using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Animals.Enums;

namespace Inheritance.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender) : base(name, age, gender)
        {
            this.Gender = Gender.Male;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }
    }
}
