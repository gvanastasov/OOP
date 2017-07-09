using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Startup
    {
        private static Dictionary<string, Car> cars = new Dictionary<string, Car>();

        static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                var tokens = Console.ReadLine().Split();

                var model = tokens[0];
                var fuel = double.Parse(tokens[1]);
                var fpk = double.Parse(tokens[2]);

                cars.Add(model, new Car(model, fuel, fpk));
            }

            while (true)
            {
                var cmd = Console.ReadLine();

                if(cmd.ToLower() == "end")
                {
                    break;
                }

                var tokens = cmd.Split();
                var model = tokens[1];
                var distance = double.Parse(tokens[2]);

                cars[model].Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value.ToString());
            }
        }
    }
}
