using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public override double area { get; protected set; }
        private double a;
        private double b;
        private double c;
        public double A 
        {
            get { return this.a; } 
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("a must be more than 0.0");
                }
                else
                    this.a = value;
            }
        }
        public double B 
        {
            get { return this.b; } 
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("b must be more than 0.0");
                }
                else
                    this.b = value;
            }
        }
        public double C
        {
            get { return this.c; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("c must be more than 0.0");
                }
                else
                    this.c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (checkSides(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
                throw new ArgumentException("Each sides must be less than sum over");
        }

        // формула Герона
        public override void CalcArea()
        {
            double p = this.CalcPerimetr();

            this.area = Math.Round(Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c)), 2);
        }
        private double CalcPerimetr()
        {
            return (this.a + this.b + this.c) / 2;
        }
        public bool isRight()
        {
            return Math.Pow(this.a, 2.0) == Math.Pow(this.b, 2.0) + Math.Pow(this.c, 2.0) ? true :
                Math.Pow(this.b, 2.0) == Math.Pow(this.a, 2.0) + Math.Pow(this.c, 2.0) ? true :
                Math.Pow(this.c, 2.0) == Math.Pow(this.a, 2.0) + Math.Pow(this.b, 2.0) ? true : false;
        }
        // каждая сторона треугольника должна быть меньше суммы 2-х остальных
        private bool checkSides(double a, double b, double c)
        {
            return a > b + c ? false :
                b > a + c ? false :
                c > a + b ? false : true;
        }
    }
}
