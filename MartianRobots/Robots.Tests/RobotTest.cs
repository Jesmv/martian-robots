using System;
using Xunit;

namespace Robots.Tests
{
    public class RobotTests
    {
        [Fact]
        
        public void CreateRobot(){
            Robot rob = new Robot(4, 2, 270);
            string result = rob.getPosition();

            Assert.Matches(result, "4 2 270");
        }

        // [Theory]
        // [InlineData("N", 0)]
        // [InlineData("E", 90)]
        // [InlineData("S", 180)]
        // [InlineData("W", 270)]
        // [InlineData("F", 360)]
        // public void cardinalToDegreesRobot(string orientation, float expect) {
        //     Robot rob = new Robot(5, 3, "W");
        //     float result = rob.cardinalToDegrees(orientation);

        //     Assert.Equal(expect, result);
        // }

        // [Theory]
        // [InlineData(0, "N")]
        // [InlineData(90, "E")]
        // [InlineData(180, "S")]
        // [InlineData(270, "W")]
        // [InlineData(55, "")]
        // public void degreesToCardinalRobot(float degrees, string expect) {
        //     Robot rob = new Robot(5, 3, "W");
        //     string result = rob.degreesToCardinal(degrees);

        //     Assert.Equal(expect, result);
        // }

        [Theory]
        [InlineData(0, 270)]
        [InlineData(90, 0)]
        [InlineData(180, 90)]
        [InlineData(270, 180)]
        public void moveLeftRobot(float orientation, float expect) {
            Robot rob = new Robot(8, 2, orientation);
            rob.rotateLeft();

            Assert.Equal( expect, rob.orientation);
        }

        [Theory]
        [InlineData(0, 90)]
        [InlineData(90, 180)]
        [InlineData(180, 270)]
        [InlineData(270, 0)]
        public void moveRightRobot(float orientation, float expect) {
            Robot rob = new Robot(8, 2, orientation);
            rob.rotateRight();

            Assert.Equal( expect, rob.orientation);
        }

        [Theory]
        [InlineData(4, 3, 0, "4 4 0")]
        [InlineData(4, 3, 90, "5 3 90")]
        [InlineData(4, 3, 180, "4 2 180")]
        [InlineData(4, 3, 270, "3 3 270")]
        public void moveForwardRobot(float x, float y, float orientation, string expect) {
            Robot rob = new Robot(x, y, orientation);
            rob.moveForward();
            string result = rob.getPosition();

            Assert.Equal(expect, result);
        }
    }
}
