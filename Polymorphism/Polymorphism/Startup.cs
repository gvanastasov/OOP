using Polymorphism.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Startup
    {
        static void Main(string[] args)
        {
            var carTokens = Console.ReadLine().Split(' ');
            var truckTokens = Console.ReadLine().Split(' ');

            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

            var cmdCount = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            for (int i = 0; i < cmdCount; i++)
            {
                var cmdTokens = Console.ReadLine().Split(' ');
                var val = double.Parse(cmdTokens[2]);

                if (cmdTokens[0] == "Drive")
                {
                    if (cmdTokens[1] == "Car")
                    {
                        output.AppendLine(car.Drive(val));
                    }
                    else
                    {
                        output.AppendLine(truck.Drive(val));
                    }
                }
                else if(cmdTokens[0] == "Refuel")
                {
                    if (cmdTokens[1] == "Car")
                    {
                        car.Refuel(val);
                    }
                    else
                    {
                        truck.Refuel(val);
                    }
                }
            }

            output.AppendLine(car.ToString());
            output.AppendLine(truck.ToString());

            Console.WriteLine(output.ToString());
        }
    }
}
