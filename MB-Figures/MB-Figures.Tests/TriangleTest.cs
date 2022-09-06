using MB_Figures.Figures;

namespace MB_Figures.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DataRow(-10, 7, 9)]
        [DataRow(10, -7, 9)]
        [DataRow(10, 7, -9)]
        [DataRow(10, 0, -9)]
        [DataRow(0, 0, 0)]
        [DataRow(100, 7, 9)]
        [DataRow(10, 7, 9)]
        public void Constructor_FailedWithException(double sideA, double sideB, double sideC)
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}