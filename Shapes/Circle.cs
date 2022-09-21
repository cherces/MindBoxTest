using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        public override double area { get; protected set; }
        private double radius;
        public double Radius 
        {
            get { return this.radius; } 
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("radius must be more than 0");
                }
                else
                    this.radius = value;
            }
        }

        public Circle(double r)
        {
            this.Radius = r;
        }
        public override void CalcArea()
        {
            this.area = Math.Round(Math.PI * Math.Pow(radius, 2.0), 2);
        }
    }
}
