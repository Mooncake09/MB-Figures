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
        public void Constructor_FailedWithException(double sideA, double sideB, double sideC)
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        [DataRow(5, 8, 9.43398)]
        [DataRow(3, 4, 5)]
        [DataRow(4.57, 7, 8.35972)]
        [DataRow(51.12356, 120.46422, 109.078)]
        public void IsTriangleIsRectangular_TrueReturned(double sideA, double sideB, double sideC)
        {
            //arrange
            var expected = true;

            //act
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.IsRectangular;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(12, 41, 52, 110.6)]
        [DataRow(0.6, 0.3, 0.8, 0.1)]
        [DataRow(5, 8, 9.433, 20)]
        public void GetFigureArea_success(double sideA, double sideB, double sideC, double expected)
        {
            //act
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.GetFigureArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}