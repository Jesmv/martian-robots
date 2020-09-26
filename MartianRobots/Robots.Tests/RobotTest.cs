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
    }
}
