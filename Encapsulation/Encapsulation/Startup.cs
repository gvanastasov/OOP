using Encapsulation.PizzaCalories;
using Encapsulation.PizzaCalories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Startup
    {
        static void Main()
        {
            Task4();
        }

        private static void Task1()
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var box = new Box(l, w, h);
            Console.WriteLine(box.ToString());
        }

        private static void Task2()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var chicken = new Chicken(name, age);

            Console.WriteLine(chicken.ToString());
        }

        private static void Task3()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            try
            {
                var peopleString = Console.ReadLine();
                var peopleTokens = peopleString.Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < peopleTokens.Length; j+=2)
                {
                    var name = peopleTokens[j];
                    var money = decimal.Parse(peopleTokens[j+1]);

                    var person = new Person(name, money);
                    people.Add(person);
                }

                var productString = Console.ReadLine();
                var productTokens = productString.Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productTokens.Length; i+=2)
                {
                    var name = productTokens[i];
                    var cost = decimal.Parse(productTokens[i + 1]);

                    var product = new Product(name, cost);
                    products.Add(product);
                }

                var output = new StringBuilder();
                while (true)
                {
                    var cmd = Console.ReadLine();

                    if(cmd.ToLower() == "end")
                    {
                        break;
                    }

                    var orderTokens = cmd.Split(' ');

                    var person = people.FirstOrDefault(p => p.Name == orderTokens[0]);
                    var product = products.FirstOrDefault(p => p.Name == orderTokens[1]);

                    if(person.Money >= product.Cost)
                    {
                        person.BuyProduct(product);
                        output.AppendLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        output.AppendLine($"{person.Name} can't afford {product.Name}");
                    }
                }

                foreach (var person in people)
                {
                    output.AppendLine($"{person.Name} - {person.GetCart()}");
                }

                Console.WriteLine(output.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Task4()
        {
            try
            {
                var pizzaTokens = Console.ReadLine().Split(' ');
                var doughTokens = Console.ReadLine().Split(' ');

                var pizza = new Pizza(pizzaTokens[1], int.Parse(pizzaTokens[2]));
                pizza.dough = new Dough(doughTokens[1], doughTokens[2], int.Parse(doughTokens[3]));

                for (int i = 0; i < int.Parse(pizzaTokens[2]); i++)
                {
                    var toppingTokens = Console.ReadLine().Split(' ');

                    var topping = new Topping(toppingTokens[1], int.Parse(toppingTokens[2]));

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
