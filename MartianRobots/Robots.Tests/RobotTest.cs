using System;
using Xunit;

namespace Robots.Tests
{
    public class RobotTests
    {
        [Fact]
        
        public void CreateRobot(){
            Robot rob = new Robot(4, 2, "W");
            string result = rob.printRobot();

            Assert.Matches(result, "4 2 W");
        }

        [Theory]
        [InlineData("L", "W")]
        [InlineData("R", "E")]
        public void RotateRobot(string value, string expect){
            Robot rob = new Robot(4, 2, "N");
            rob.rotate(value);

            Assert.Equal(expect, rob.orientation);
        }

        [Theory]
        [InlineData("N", 0)]
        [InlineData("E", 90)]
        [InlineData("S", 180)]
        [InlineData("W", 270)]
        [InlineData("F", 360)]
        public void cardinalToDegreesRobot(string orientation, float expect) {
            Robot rob = new Robot(5, 3, "W");
            float result = rob.cardinalToDegrees(orientation);

            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0, "N")]
        [InlineData(90, "E")]
        [InlineData(180, "S")]
        [InlineData(270, "W")]
        [InlineData(55, "")]
        public void degreesToCardinalRobot(float degrees, string expect) {
            Robot rob = new Robot(5, 3, "W");
            string result = rob.degreesToCardinal(degrees);

            Assert.Equal(expect, result);
        }
    }
}
