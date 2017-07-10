using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Startup
    {
        private static HashSet<Rectangle> rects = new HashSet<Rectangle>();

        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();

            var rectanglesCount = int.Parse(tokens[0]);
            var checksCount = int.Parse(tokens[1]);

            for (int i = 0; i < rectanglesCount; i++)
            {
                var data = Console.ReadLine().Split();
                var rect = new Rectangle(data[0], double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]));

                rects.Add(rect);
            }

            for (int i = 0; i < checksCount; i++)
            {
                var data = Console.ReadLine().Split();

                var rectA = rects.FirstOrDefault(x => x.Id == data[0]);
                var rectB = rects.FirstOrDefault(x => x.Id == data[1]);

                Console.WriteLine(rectA.Intersect(rectB));
            }
        }
    }
}
