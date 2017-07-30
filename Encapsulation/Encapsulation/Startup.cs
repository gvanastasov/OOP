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
            Task3();
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
    }
}
