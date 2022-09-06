using MB_Figures.Figures.Interfaces;

namespace MB_Figures
{
    public class Geometry
    {
        public IFigure Figure { get; }

        /// <summary>
        /// Geometry is a base class that provides an interface for working with shapes.
        /// Possible constructors of geometric shapes:
        /// new Circle, new Triangle
        /// </summary>
        /// <param name="figure"></param>
        
        public Geometry(IFigure figure)
        {
            Figure = figure;
        }

        public double CalculateArea()
        {
           return Figure.GetFigureArea();
        }
    }
}