using System;
using Xunit;

namespace Robots.Tests
{
    public class RobotTests
    {
        [Fact]
        
        public void CreateRobot(){
            Robot rob = new Robot(4, 2, 270);
            string result = rob.GetPosition();

            Assert.Matches(result, "4 2 W");
        }
    }
}
