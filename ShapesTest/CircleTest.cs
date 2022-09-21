using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTest
{
    [TestClass]
    public class CircleTest
    {
        [ExpectedException(typeof(System.ArgumentException), "Circle radius less than 0")]
        [TestMethod]
        public void CircleRadiusMoreThanZeroTest()
        {
            Figures.Figure figure = new Figures.Circle(-1);
        }

        [ExpectedException(typeof(System.ArgumentException), "Circle radius is 0")]
        [TestMethod]
        public void CircleRadiusNotZeroTest()
        {
            Figures.Figure figure = new Figures.Circle(0);
        }

        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 5.0;
            double expected = 78.54;
            Figures.Figure figure = new Figures.Circle(radius);
            figure.CalcArea();

            Assert.AreEqual(expected, figure.area, "Circle with radius = {0} should have been area = {1}", radius, expected);
        }
    }
}
