using System;
using System.IO;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = args[0];

            ValidateFileExists(filename);

            InputData inputData = InputParser.Parse(filename);

            RobotsController controller = new RobotsController(inputData.planet);

            foreach (RobotInstructions robotInstructions in inputData.instructions)
            {
                Robot robot = controller.initializeRobot(robotInstructions.initialPosition);
                controller.moveRobot(robot, robotInstructions.movements);
                Console.WriteLine(robot.getPosition());
            }
        }

        static void ValidateFileExists(string filename) {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist");
                Environment.Exit(1);
            } 
        }
    }
}
