using System;
using System.Collections.Generic;
using System.IO;



class InputData {

    public readonly Planet planet;
    public readonly List<RobotInstructions> instructions;

    public InputData(Planet planet, List<RobotInstructions> instructions) {
        this.planet = planet;
        this.instructions = instructions;
    }

}

class RobotInstructions {
    public readonly string initialPosition;
    public readonly string movements;

    public RobotInstructions(string initialPosition, string movements) {
        this.initialPosition = initialPosition;
        this.movements = movements;
    }
}

class InputParser {

    public static InputData Parse(string filename) {

        Planet planet;
        List<RobotInstructions> instructions = new List<RobotInstructions>();

        using (StreamReader read = new StreamReader(filename))
        {
            string line;

            string linePlanet = read.ReadLine();
            string[] planetCoordinates = linePlanet.Split(" ");

            int x = int.Parse(planetCoordinates[0]);
            int y = int.Parse(planetCoordinates[1]);
            
            if (x <= 50 && y <= 50 && x > 0 && y > 0) {
                planet = new Planet(x, y);

                int count = 1;
                string startPosition = string.Empty;

                while ((line = read.ReadLine()) != null)
                {
                    if (count > 0 && count % 2!=0) {
                        startPosition = line;
                    } else if (count > 0 && count % 2==0) {
                        if (line.Length <= 100)
                        {
                            instructions.Add(new RobotInstructions(startPosition, line));
                        } else {
                            throw new Exception("Invalid instruction, will be less than 100 movements.");
                        }
                    }
                    count ++;
                }
            } else {
                throw new Exception("Invalid Planet, maximum value per coordinate is 50.");
            }

            return new InputData(planet, instructions);
        }
    }

}