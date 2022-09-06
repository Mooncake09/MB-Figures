using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_Figures.Figures.Interfaces
{
    internal interface ITriangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRectangular { get; }
    }
}
