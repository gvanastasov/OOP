using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inheritance.Mankind
{
    public abstract class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(Regex.IsMatch(value, "^[A-Z].*$") ==  false)
                {
                    throw new Exception($"Expected upper case letter! Argument: {value}");
                }

                if(value.Length < 3)
                {
                    throw new Exception($"Expected length at least 4 symbols! Argument: {value}");
                }

                this.firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (Regex.IsMatch(value, "^[A-Z].*$") == false)
                {
                    throw new Exception($"Expected upper case letter! Argument: {value}");
                }

                if (value.Length < 2)
                {
                    throw new Exception($"Expected length at least 4 symbols! Argument: {value}");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            return sb.ToString();
        }
    }
}
