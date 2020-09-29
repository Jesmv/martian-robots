using System;
using System.Collections.Generic;
using System.IO;
public class InputData
{
    public readonly Planet planet;
    public readonly List<RobotInstructions> instructions;

    public InputData(Planet planet, List<RobotInstructions> instructions)
    {
        this.planet = planet;
        this.instructions = instructions;
    }
}

public class RobotInstructions
{
    public readonly string initialPosition;
    public readonly List<IMovement> movements;

    public RobotInstructions(string initialPosition, List<IMovement> movements)
    {
        this.initialPosition = initialPosition;
        this.movements = movements;
    }
}

public class InputParser
{
    public static InputData Parse(string filename)
    {

        Planet planet;
        List<RobotInstructions> instructions = new List<RobotInstructions>();

        using (StreamReader read = new StreamReader(filename))
        {
            string line;

            string linePlanet = read.ReadLine();
            string[] planetCoordinates = linePlanet.Split(" ");

            float x = float.Parse(planetCoordinates[0]);
            float y = float.Parse(planetCoordinates[1]);

            if (x <= 50 && y <= 50 && x > 0 && y > 0)
            {
                planet = new Planet(x, y);

                int count = 1;
                string startPosition = string.Empty;

                while ((line = read.ReadLine()) != null)
                {
                    if (count > 0 && count % 2 != 0)
                    {
                        startPosition = line;
                    }
                    else if (count > 0 && count % 2 == 0)
                    {
                        if (line.Length <= 100)
                        {
                            List<IMovement> movementList = parseMovementList(line);
                            instructions.Add(new RobotInstructions(startPosition, movementList));
                        }
                        else
                        {
                            throw new Exception("Invalid instruction, will be less than 100 movements.");
                        }
                    }
                    count++;
                }
            }
            else
            {
                throw new Exception("Invalid Planet, maximum value per coordinate is 50.");
            }

            return new InputData(planet, instructions);
        }
    }

    public static List<IMovement> parseMovementList(string line)
    {
        List<IMovement> movementList = new List<IMovement>();
        foreach (var item in line)
        {
            IMovement movement;

            switch (item)
            {
                case 'L':
                    movement = new RotateLeft();
                    break;
                case 'R':
                    movement = new RotateRight();
                    break;
                case 'F':
                    movement = new MoveForward();
                    break;
                case ' ':
                    continue;
                default:
                    throw new Exception("Invalid movement");

            }

            movementList.Add(movement);
        }

        return movementList;
    }
}