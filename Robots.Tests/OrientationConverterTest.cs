using System;
using Xunit;

namespace Robots.Tests
{
    public class ConversionTest
    {
        [Theory]
        [InlineData("N", 0)]
        [InlineData("E", 90)]
        [InlineData("S", 180)]
        [InlineData("W", 270)]
        public void orintationTest(string orientation, float expect) {
            
            float result = OrientationConverter.CardinalToDegrees(orientation);

            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0, "N")]
        [InlineData(90, "E")]
        [InlineData(180, "S")]
        [InlineData(270, "W")]
        public void degreesToCardinalTest(float orientation, string expect) {
            
            string result = OrientationConverter.DegreesToCardinal(orientation);

            Assert.Equal(expect, result);
        }
    }
}

