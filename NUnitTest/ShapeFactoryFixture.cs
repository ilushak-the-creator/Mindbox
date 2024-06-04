using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox;
using NUnit.Framework.Internal;

namespace NUnitTest
{
    [TestFixture]
    public class ShapeFactoryFixture
    {
        [Test]
        public void CreateCircle_ReturnsCircle()
        {
            //arrange
            var radius = 5;

            //act
            var circle = ShapeFactory.CreateCircle(radius);

            //assert
            Assert.NotNull(circle);
            Assert.IsTrue(circle is Circle);
        }

        [Test]
        public void CreateTriangle_ReturnsTriangle()
        {
            //arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;

            //act
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);

            //assert
            Assert.NotNull(triangle);
            Assert.IsTrue(triangle is Triangle);
        }

        [Test]
        public void CreateTriangle_ThrowsException()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 0;

            Assert.Throws<ArgumentException>(() => { ShapeFactory.CreateTriangle(sideA, sideB, sideC); });
        }
    }
}