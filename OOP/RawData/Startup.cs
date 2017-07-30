using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Startup
    {
        private static HashSet<Car> cars = new HashSet<Car>();

        static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var car = new Car(tokens);

                cars.Add(car);
            }

            var cmd = Console.ReadLine();

            switch (cmd)
            {
                case "fragile":
                    {
                        foreach (var car in cars.Where(x => x.Cargo.CargoType == CargoType.fragile && x.HasFlatTire))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                case "flamable":
                    {
                        foreach (var car in cars.Where(x => x.Cargo.CargoType == CargoType.flamable && x.HasBigEngine))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
