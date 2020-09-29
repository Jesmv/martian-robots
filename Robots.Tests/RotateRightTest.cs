using System;
using Xunit;
public class RotateRightTest
{
    [Theory]
    [InlineData(0, 90)]
    [InlineData(90, 180)]
    [InlineData(180, 270)]
    [InlineData(270, 0)]
    public void RotateRightRobot(float orientation, float expect) {
        Robot robot = new Robot(8, 2, orientation);

        RotateRight movement = new RotateRight();
        movement.Move(robot);

        Assert.Equal(expect, robot.orientation);
    }
}