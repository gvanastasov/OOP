using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Person
    {
        public string name;
        public int age;

        public Person() : this(1, "No name")
        {
        }

        public Person(int age) : this(age, "No name")
        {
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }
    }
}
