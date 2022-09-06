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
