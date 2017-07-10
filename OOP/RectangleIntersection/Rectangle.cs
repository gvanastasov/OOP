using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double coord_x { get; set; }
        public double coord_y { get; set; }

        public Rectangle(string id, double width, double height, double coord_x, double coord_y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.coord_x = coord_x;
            this.coord_y = coord_y;
        }

        public bool Intersect(Rectangle other)
        {
            return other.coord_x >= this.coord_x && 
                other.coord_x <= this.coord_x + this.Width &&
                other.coord_y >= this.coord_y && 
                other.coord_y <= this.coord_y + this.Height;
        }
    }
}
