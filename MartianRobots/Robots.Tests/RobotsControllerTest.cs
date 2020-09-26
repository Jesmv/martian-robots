using System;
using Xunit;
public class RobotsControllerTest
{
    [Fact]
    public void testInitializeRobot()
    {
        RobotsController controller = new RobotsController();
        Robot robot = controller.initializeRobot("1 2 E");

        Assert.Equal("1 2 90", robot.getPosition());
    }

    [Theory]
    [InlineData("1 1 E", "RFRFRFRF", "1 1 90")]
    [InlineData("0 3 W", "LLFFF", "3 3 90")]
    public void testMoveRobot(string position, string movements, string expected)
    {
        RobotsController controller = new RobotsController();
        Robot robot = controller.initializeRobot(position);

        controller.moveRobot(robot, movements);

        Assert.Equal(expected, robot.getPosition());
    }
}