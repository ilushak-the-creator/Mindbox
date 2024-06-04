using Mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    public class ShapeAreaCalculatorFixture
    {
        [Test]
        public void CalculateArea_WithTriangle_Should_Return_CorrectArea()
        {
            //arrange
            var triangle = new Triangle(3, 4, 5);

            //act
            var area = ShapeAreaCalculator.CalculateArea(triangle);

            //assert
            Assert.NotNull(area);
            Assert.AreEqual(6, area);
        }

        [Test]
        public void CalculateArea_WithCircle_Should_Return_CorrectArea()
        {
            //arrange
            var circle = new Circle(5);

            //act
            var area = ShapeAreaCalculator.CalculateArea(circle);

            //assert
            Assert.NotNull(area);
            Assert.AreEqual(Math.PI * 5 * 5, area);
        }
    }
}
