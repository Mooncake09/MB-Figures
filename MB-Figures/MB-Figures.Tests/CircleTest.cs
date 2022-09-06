using MB_Figures.Figures;

namespace MB_Figures.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetFigureArea_15_706returned()
        {
            //arrange
            double radius = 15d;
            double expected = 706.85835;

            //act
            var circle = new Circle(radius);
            var actual = circle.GetFigureArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}