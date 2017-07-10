using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Startup
    {
        private static HashSet<Car> cars = new HashSet<Car>();
        private static HashSet<Engine> engines = new HashSet<Engine>();

        static void Main(string[] args)
        {
            var engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                var data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var model = data[0];
                var power = data[1];

                var engine = new Engine(model, power);

                if (data.Length == 3)
                {
                    var disp = 0;
                    if (int.TryParse(data[2], out disp))
                    {
                        engine.Displacement = disp;
                    }
                    else
                    {
                        engine.Efficiency = data[2];
                    }
                }
                else if(data.Length == 4)
                {
                    engine.Displacement = int.Parse(data[2]);
                    engine.Efficiency = data[3];
                }

                engines.Add(engine);
            }

            var carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                var data = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                var model = data[0];
                var engine = engines.FirstOrDefault(e => e.Model == data[1]);

                var car = new Car()
                {
                    Model = model,
                    Engine = engine
                };

                if(data.Length == 3)
                {
                    var weight = 0;
                    if(int.TryParse(data[2], out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = data[2];
                    }
                }

                else if(data.Length == 4)
                {
                    car.Weight = double.Parse(data[2]);
                    car.Color = data[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
