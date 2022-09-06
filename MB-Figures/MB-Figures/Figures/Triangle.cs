using MB_Figures.Figures.Interfaces;

namespace MB_Figures.Figures
{
    public class Triangle : ITriangle
    {
        private readonly double _epsilon = 0.1;

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRectangular { get; }

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

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (sideA == sideB && sideB == sideC)
            {
                IsRectangular = false; //The triangle is equilateral
                return;
            }

            IsRectangular = IsTriangleIsRectangular();
        }

        public double GetFigureArea()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC)), 1);
        }

        private bool IsTriangleIsRectangular()
        {
            var sortedList = new List<double>(3) { SideA, SideB, SideC };
            //Sort the sides of the triangle in ascending order
            sortedList.Sort();

            var hypotenuse = sortedList[2]; //Hypotenuse is the largest side
            var cathetA = sortedList[1];
            var cathetB = sortedList[0];

            var hPow2 = Math.Pow(hypotenuse, 2);
            var aPow2 = Math.Pow(cathetA, 2);
            var bPow2 = Math.Pow(cathetB, 2);

            var aPow2_bPow2_Sum = aPow2 + bPow2;

            //check by the pythagorean theorem c^2 = a^2 + b^2
            return hPow2.EqualTo(aPow2_bPow2_Sum, _epsilon);
        }
    }
}
