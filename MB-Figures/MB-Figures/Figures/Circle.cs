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

        public double GetFigureArea()
        {
            return Math.Round(PI * Math.Pow(Radius, 2), 5);
        }
    }
}
