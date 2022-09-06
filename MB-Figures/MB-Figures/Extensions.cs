namespace MB_Figures
{
    public static class Extensions
    {
        public static bool EqualTo(this double value1, double value2, double epsilon = 0.1)
        {
            return Math.Abs(value1 - value2) < epsilon;
        }
    }
}
