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

    [Fact]
    public void testMoveRobot()
    {
        RobotsController controller = new RobotsController();
        Robot robot = controller.initializeRobot("1 1 E");

        controller.moveRobot(robot, "RFRFRFRF");

        Assert.Equal("1 1 90", robot.getPosition());
    }
}