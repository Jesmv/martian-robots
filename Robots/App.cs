using System;
using System.IO;

namespace Robots
{
    class App
    {
        static void Main(string[] args)
        {
            ValidateFileExists(args);

            InputData inputData = InputParser.Parse(args[0]);

            RobotsController controller = new RobotsController(inputData.planet);

            foreach (RobotInstructions robotInstructions in inputData.instructions)
            {
                Robot robot = controller.InitializeRobot(robotInstructions.initialPosition);
                controller.MoveRobot(robot, robotInstructions.movements);
                Console.WriteLine(robot.GetPosition());
            }
        }

        static void ValidateFileExists(string[] args) {

            if (args.Length == 0) {
                Console.WriteLine("Specify an input file");
                Environment.Exit(1);
            }

            string filename = args[0];

            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist");
                Environment.Exit(1);
            } 
        }
    }
}
