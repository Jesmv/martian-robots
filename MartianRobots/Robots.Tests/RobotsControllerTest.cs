using System;
using Xunit;
public class RobotsControllerTest
{
    [Fact]
    public void testInitializeRobot()
    {
        RobotsController controller = new RobotsController();
        Robot robot = controller.initializeRobot("1 2 E");

        Assert.Equal("1 2 E", robot.printRobot());
    }
}