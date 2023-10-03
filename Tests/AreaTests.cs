using AreaLibrary.Interfaces;
using AreaLibrary.Shapes;
using AreaLibrary.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Tests
{
    [TestFixture]
    public class AreaTests
    {
        [Test]
        public void CircleAreaCalculationTest()
        {
            IShape circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;
            double actualArea = AreaCalculator.CalculateArea(circle);
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void TriangleAreaCalculationTest()
        {
            IShape triangle = new Triangle(3, 4, 5);
            double expectedArea = 6.0;
            double actualArea = AreaCalculator.CalculateArea(triangle);
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }
}
