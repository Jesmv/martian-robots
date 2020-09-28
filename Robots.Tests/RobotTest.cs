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

            Assert.Matches(result, "4 2 W");
        }

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
        [InlineData(4, 3, 0, "4 4 N")]
        [InlineData(4, 3, 90, "5 3 E")]
        [InlineData(4, 3, 180, "4 2 S")]
        [InlineData(4, 3, 270, "3 3 W")]
        public void moveForwardRobot(float x, float y, float orientation, string expect) {
            Robot rob = new Robot(x, y, orientation);
            rob.moveForward();
            string result = rob.getPosition();

            Assert.Equal(expect, result);
        }
    }
}
