using MB_Figures.Figures;

namespace MB_Figures.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [DataRow(15, 706.85835)]
        [DataRow(0.14, 0.06158)]
        [DataRow(123035.19423221, 47556358369.01787)]
        public void GetFigureArea_success(double radius, double expected)
        {
            //act
            var circle = new Circle(radius);
            var actual = circle.GetFigureArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}