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
    }
}
