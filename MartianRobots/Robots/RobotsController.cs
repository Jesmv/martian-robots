public class RobotsController {
    public Robot robot;
    public Robot initializeRobot(string position) {

        string[] parsedPositions = position.Split(" ");
        int x = int.Parse(parsedPositions[0]);
        int y = int.Parse(parsedPositions[1]);
        string orientation = parsedPositions[2];
       
        Robot robot = new Robot(x, y, orientation);

        return robot;
    }
}