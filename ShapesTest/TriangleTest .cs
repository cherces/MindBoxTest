using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTest
{
    [TestClass]
    public class TriangleTest
    {
        [ExpectedException(typeof(System.ArgumentException), "Triangle side A less than 0 or equal")]
        [TestMethod]
        public void TriangleSideAMoreThanZeroTest()
        {
            Figures.Triangle triangle = new Figures.Triangle(3.0, 4.0, 5.0);
            triangle.A = 0.0;
        }

        [ExpectedException(typeof(System.ArgumentException), "Triangle side B less than 0 or equal")]
        [TestMethod]
        public void TriangleSideBMoreThanZeroTest()
        {
            Figures.Triangle triangle = new Figures.Triangle(3.0, 4.0, 5.0);
            triangle.B = -7.0;
        }
        
        [ExpectedException(typeof(System.ArgumentException), "Triangle side C less than 0 or equal")]
        [TestMethod]
        public void TriangleSideCMoreThanZeroTest()
        {
            Figures.Triangle triangle = new Figures.Triangle(3.0, 4.0, 5.0);
            triangle.C = -3.0;
        }

        [ExpectedException(typeof(System.ArgumentException), "Each triangle sides must be less than sum over")]
        [TestMethod]
        public void TriangleSidesRatioTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 80.0;

            Figures.Triangle triangle = new Figures.Triangle(a, b, c);
        }

        [TestMethod]
        public void SimpleTriangleAreaTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expected = 6.0;

            Figures.Triangle triangle = new Figures.Triangle(a, b, c);
            triangle.CalcArea();

            Assert.AreEqual(expected, triangle.area, "Simple triangle with sides a = {0}, b = {1}, c = {2} should have been area = {3}", a, b, c, expected);
        }

        [TestMethod]
        public void RightTriangleAreaTest()
        {
            double a = 6.0;
            double b = 8.0;
            double c = 10.0;
            bool expected = true;

            Figures.Triangle triangle = new Figures.Triangle(a, b, c);
            
            Assert.AreEqual(expected, triangle.isRight(), "Triangle with sides a = {0}, b = {1}, c = {2} should be right", a, b, c);
        }

        [TestMethod]
        public void NotRightTriangleAreaTest()
        {
            double a = 6.0;
            double b = 7.0;
            double c = 10.0;
            bool expected = false;

            Figures.Triangle triangle = new Figures.Triangle(a, b, c);

            Assert.AreEqual(expected, triangle.isRight(), "Triangle with sides a = {0}, b = {1}, c = {2} shouldn't be right", a, b, c);
        }
    }
}
