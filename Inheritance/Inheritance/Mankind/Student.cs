using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Mankind
{
    public class Student : Human
    {
        public Student(string firstName, 
            string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string facultyNumber;
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(value.Length < 5 || value.Length > 10)
                {
                    throw new Exception("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
