using System;
using System.Collections.Generic;
using Xunit;
public class RotateLeftTest
{
    [Theory]
    [InlineData(0, 270)]
    [InlineData(90, 0)]
    [InlineData(180, 90)]
    [InlineData(270, 180)]
    public void RotateLeftRobot(float orientation, float expect) {
        Robot robot = new Robot(8, 2, orientation);

        RotateLeft movement = new RotateLeft();
        movement.Move(robot);

        Assert.Equal(expect, robot.orientation);
    }
}