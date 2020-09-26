using System;

public class RobotsController {
    public Robot initializeRobot(string position) {

        string[] parsedPositions = position.Split(" ");
        int x = int.Parse(parsedPositions[0]);
        int y = int.Parse(parsedPositions[1]);
        float orientation = this.cardinalToDegrees(parsedPositions[2]);
       
        Robot robot = new Robot(x, y, orientation);

        return robot;
    }

    public void moveRobot(Robot robot, string movements)
    {
        foreach (char movement in movements)
        {
            switch (movement)
            {
                case 'L':
                    robot.rotateLeft();
                    break;
                case 'R':
                    robot.rotateRight();
                    break;
                case 'F':
                    robot.moveForward();
                    break;
                default:
                    throw new Exception("Invalid movement");

            }
        }
    }

    public float cardinalToDegrees(string orientation) {
        switch (orientation)
        {
            case "N":
                return 0;
            case "E":
                return 90;
            case "S":
                return 180;
            case "W":
                return 270;    
            default:
                throw new Exception("Invalid Cardinal points");
        }
    }

    public string degreesToCardinal(float orientation) {
        switch (orientation)
        {
            case 0:
                return "N";
            case 90:
                return "E";
            case 180:
                return "S";
            case 270:
                return "W";    
            default:
                throw new Exception("Invalid degrees");
        }
    }
}