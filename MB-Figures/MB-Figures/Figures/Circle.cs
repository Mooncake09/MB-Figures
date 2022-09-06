using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB_Figures.Figures.Interfaces;

namespace MB_Figures.Figures
{
    public class Circle : ICircle
    {
        private readonly double PI = Math.PI;
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("The radius cannot be less than zero", nameof(radius));

            Radius = radius;
        }

        public double CalculateArea()
        {
            return PI * Math.Pow(Radius, 2d);
        }
    }
}
