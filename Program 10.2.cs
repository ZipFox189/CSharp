using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTest1
{
    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public void TestPointToString()
        {
            // Arrange
            var point = new Point(2, 3);

            // Act
            var result = point.ToString();

            // Assert
            Assert.AreEqual("(2,3)", result);
        }

        [TestMethod]
        public void TestTriangleDistance()
        {
            // Arrange
            var vertex1 = new Point(0, 0);
            var vertex2 = new Point(3, 0);
            var vertex3 = new Point(0, 4);
            var triangle = new Triangle(vertex1, vertex2, vertex3);

            // Act
            var distance = triangle.Distance(vertex1, vertex2);

            // Assert
            Assert.AreEqual(3, distance);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            // Arrange
            var vertex1 = new Point(0, 0);
            var vertex2 = new Point(3, 0);
            var vertex3 = new Point(0, 4);
            var triangle = new Triangle(vertex1, vertex2, vertex3);

            // Act
            var perimeter = triangle.Perimeter();

            // Assert
            Assert.AreEqual(12, perimeter);
        }

        [TestMethod]
        public void TestTriangleSquare()
        {
            // Arrange
            var vertex1 = new Point(0, 0);
            var vertex2 = new Point(3, 0);
            var vertex3 = new Point(0, 4);
            var triangle = new Triangle(vertex1, vertex2, vertex3);

            // Act
            var square = triangle.Square();

            // Assert
            Assert.AreEqual(6, square);
        }

        [TestMethod]
        public void TestTrianglePrint()
        {
            // Arrange
            var vertex1 = new Point(0, 0);
            var vertex2 = new Point(3, 0);
            var vertex3 = new Point(0, 4);
            var triangle = new Triangle(vertex1, vertex2, vertex3);

            // Act
            var result = triangle.Print();

            // Assert
            Assert.AreEqual("Triangle with vertices (0,0), (3,0), and (0,4)", result);
        }
    }
}
