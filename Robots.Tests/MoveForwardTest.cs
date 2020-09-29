using System;
using Xunit;
public class MoveForwardTest
{
    [Theory]
    [InlineData(4, 3, 0, "4 4 N")]
    [InlineData(4, 3, 90, "5 3 E")]
    [InlineData(4, 3, 180, "4 2 S")]
    [InlineData(4, 3, 270, "3 3 W")]
    public void MoveForwardRobotTest(float x, float y, float orientation, string expect) {
        Robot robot = new Robot(x, y, orientation);

        MoveForward movement = new MoveForward();
        movement.Move(robot);

        Assert.Equal(expect, robot.GetPosition());
    }
}