using System;
using System.Collections.Generic;
using Xunit;
public class RobotsControllerTest
{
    [Fact]
    public void TestInitializeRobot()
    {
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        Robot robot = controller.InitializeRobot("1 2 E");

        Assert.Equal("1 2 E", robot.GetPosition());
    }

    [Theory]
    [InlineData("1 1 E", "RFRFRFRF", "1 1 E")]
    [InlineData("0 3 W", "LLFFF", "3 3 E")]
    [InlineData("3 2 N", "FRRFLLFFRRFLL", "3 3 N LOST")]
    [InlineData("3 2 N", "FRRFLLFFRFFFFFFFLL", "3 3 N LOST")]

    public void TestMoveRobot(string position, string movementsString, string expected)
    {
        List<IMovement> movements = InputParser.parseMovementList(movementsString);
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        Robot robot = controller.InitializeRobot(position);

        controller.MoveRobot(robot, movements);

        Assert.Equal(expected, robot.GetPosition());
    }

    [Fact]
    public void TestScentProtection()
    {
        Planet planet = new Planet(5, 3);
        RobotsController controller = new RobotsController(planet);
        
        Robot robot = controller.InitializeRobot("3 2 N");

        controller.MoveRobot(robot, InputParser.parseMovementList("FRRFLLFFRRFLL"));

        Robot robot2 = controller.InitializeRobot("0 3 W");
        controller.MoveRobot(robot2, InputParser.parseMovementList("LLFFFLFLFL"));

        Assert.Equal("2 3 S", robot2.GetPosition());
    }
}