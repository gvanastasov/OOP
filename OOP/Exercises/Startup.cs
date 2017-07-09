using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Startup
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);

            // ex.1
            //Definition(personType);

            // ex.2
            //CreatingConstructors(personType);

            // ex.3
            //OldestFamilyMember();

            // ex.4
            //OpinionPoll();

            // ex.5 
            //Dates();

            // ex.6
            //CompanyRoster();
        }

        private static void Definition(Type personType)
        {
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var pesho = new Person();
            pesho.age = 20;
            var gosho = new Person() { age = 18 };
            var stamat = new Person() { age = 43, name = "Stamat" };
        }

        private static void CreatingConstructors(Type personType)
        {
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);
        }

        private static void OldestFamilyMember()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();

            var memberCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < memberCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                var age = int.Parse(tokens[1]);
                var name = tokens[0];

                family.AddMember(new Person(age, name));
            }

            Console.WriteLine(family.GetOldestMember().ToString());
        }

        private static void OpinionPoll()
        {
            var family = new Family();

            var memberCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < memberCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                var age = int.Parse(tokens[1]);
                var name = tokens[0];

                if(age > 30)
                {
                    family.AddMember(new Person(age, name));
                }
            }

            foreach (var person in family.people.OrderBy(x => x.name))
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }

        private static void Dates()
        {
            var dateStringOne = Console.ReadLine();
            var dateStringTwo = Console.ReadLine();

            var diff = Math.Abs(DateModifier.DaysDifference(dateStringOne, dateStringTwo));
            Console.WriteLine(diff);
        }

        private static void CompanyRoster()
        {
            var employees = new List<Employee>();

            var employeeCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < employeeCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                var name = tokens[0];
                var salary = double.Parse(tokens[1]);
                var position = tokens[2];
                var department = tokens[3];
                var email = string.Empty;
                int? age = null;

                if(tokens.Length == 5)
                {
                    if(tokens[4].Contains("@"))
                    {
                        email = tokens[4];
                    }
                    else
                    {
                        age = int.Parse(tokens[4]);
                    }
                }
                else if(tokens.Length == 6)
                {
                    email = tokens[4];
                    age = int.Parse(tokens[5]);
                }

                employees.Add(new Employee(name, salary, position, department, email, age));
            }

            var departmentHighestSalary = employees
                .GroupBy(x => x.Department)
                .ToDictionary(g => g.Key, g => g.Average(e => e.Salary))
                .OrderBy(x => x.Value).Last().Key;

            Console.WriteLine($"Highest Average Salary: {departmentHighestSalary}");
            foreach (var e in employees.Where(e => e.Department == departmentHighestSalary).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
