using System;
using Xunit;
public class RobotsControllerTest
{
    [Fact]
    public void testInitializeRobot()
    {
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        Robot robot = controller.initializeRobot("1 2 E");

        Assert.Equal("1 2 90", robot.getPosition());
    }

    [Theory]
    [InlineData("1 1 E", "RFRFRFRF", "1 1 90")]
    [InlineData("0 3 W", "LLFFF", "3 3 90")]
    [InlineData("3 2 N", "FRRFLLFFRRFLL", "3 3 0 LOST")]
    [InlineData("3 2 N", "FRRFLLFFRFFFFFFFLL", "3 3 0 LOST")]

    public void testMoveRobot(string position, string movements, string expected)
    {
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        Robot robot = controller.initializeRobot(position);

        controller.moveRobot(robot, movements);

        Assert.Equal(expected, robot.getPosition());
    }

    [Fact]
    public void testScentProtection()
    {
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        
        Robot robot = controller.initializeRobot("3 2 N");
        controller.moveRobot(robot, "FRRFLLFFRRFLL");

        Robot robot2 = controller.initializeRobot("0 3 W");
        controller.moveRobot(robot2, "LLFFFLFLFL");

        Assert.Equal("2 3 180", robot2.getPosition());
    }
}