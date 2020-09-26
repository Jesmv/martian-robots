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

        [Theory]
        [InlineData("N", 270)]
        [InlineData("E", 0)]
        [InlineData("S", 90)]
        [InlineData("W", 180)]
        public void moveLeftRobot(string orientation, float expect) {
            Robot rob = new Robot(8, 2, orientation);
            rob.moveLeft();

            Assert.Equal( expect, rob.degrees);
        }

        [Theory]
        [InlineData("N", 90)]
        [InlineData("E", 180)]
        [InlineData("S", 270)]
        [InlineData("W", 0)]
        public void moveRightRobot(string orientation, float expect) {
            Robot rob = new Robot(8, 2, orientation);
            rob.moveRight();

            Assert.Equal( expect, rob.degrees);
        }

        [Theory]
        [InlineData(4, 3, "N", "4 4 N")]
        [InlineData(4, 3, "E", "5 3 E")]
        [InlineData(4, 3, "S", "4 2 S")]
        [InlineData(4, 3, "W", "3 3 W")]
        public void moveForwardRobot(float x, float y, string orientation, string expect) {
            Robot rob = new Robot(x, y, orientation);
            rob.moveForward();
            string result = rob.printRobot();

            Assert.Equal(expect, result);
        }
    }
}
