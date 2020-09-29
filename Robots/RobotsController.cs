using System;
using System.Collections.Generic;

public class RobotsController {
    public Planet planet;

    public RobotsController (Planet planet) {
        this.planet = planet;
    }

    public Robot InitializeRobot(string position) {

        string[] parsedPositions = position.Split(" ");
        int x = int.Parse(parsedPositions[0]);
        int y = int.Parse(parsedPositions[1]);
        float orientation = OrientationConverter.cardinalToDegrees(parsedPositions[2]);
       
        Robot robot = new Robot(x, y, orientation);

        return robot;
    }

    public void MoveRobot(Robot robot, List<IMovement> movements)
    {
        foreach (var movement in movements)
        {
            movement.Move(robot);
            planet.CheckLimits(robot);

            if (robot.lost) break;
        }
    } 
}