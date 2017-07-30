namespace Encapsulation
{
    using System;
    using System.Text;


    public class Box
    {
        public Box(double len, double w, double h)
        {
            this.length = len;
            this.width = w;
            this.height = h;
        }

        private double length;
        public double Length
        {
            get { return this.length; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Length cannot be negative.");
                }
                this.length = value;
            }
        }

        private double width;
        public double Width
        {
            get { return this.width; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Width cannot be negative.");
                }
                this.width = value;
            }
        }

        private double height;
        public double Height
        {
            get { return this.height; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Height cannot be negative.");
                }
                this.height = value;
            }
        }

        public double GetSurfaceArea()
        {
            return 2 * (this.height * this.width) +
                   2 * (this.height * this.length) +
                   2 * (this.width * this.length);
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * (this.height * this.width) +
                   2 * (this.height * this.length);
        }

        public double GetVolume()
        {
            return this.height * this.width * this.length;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {GetSurfaceArea():f2}");
            sb.AppendLine($"Lateral Area - {GetLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {GetVolume():f2}");

            return sb.ToString();
        }
    }
}
