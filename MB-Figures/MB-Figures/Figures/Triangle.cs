using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB_Figures.Figures.Interfaces;

namespace MB_Figures.Figures
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Perimeter { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0)
                throw new ArgumentException("The side of the triangle cannot be less than zero", nameof(sideA));

            if (sideB < 0)
                throw new ArgumentException("The side of the triangle cannot be less than zero", nameof(sideB));

            if (sideC < 0)
                throw new ArgumentException("The side of the triangle cannot be less than zero", nameof(sideC));

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
                throw new ArgumentException("A triangle cannot exist with given side lengths");

            Perimeter = sideA + sideB + sideC;

        }

        public double GetFigureArea()
        {
            throw new NotImplementedException();
        }

        public bool IsTriangleIsRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
