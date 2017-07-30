using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Mankind
{
    public class Worker : Human
    {
        public Worker(string firstName, 
            string lastName, 
            decimal weekSalary, 
            int workHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        private decimal weekSalary;
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if(value < 10)
                {
                    throw new Exception("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal HourSalary
        {
            get
            {
                return this.WeekSalary / (this.WorkHours * 5);
            }
        }

        private int workHours;
        public int WorkHours
        {
            get
            {
                return this.workHours;
            }
            set
            {
                if(value < 1 || value > 12)
                {
                    throw new Exception("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHours = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHours}");
            sb.AppendLine($"Salary per hour: {this.HourSalary:f2}");

            return sb.ToString();
        }
    }
}
