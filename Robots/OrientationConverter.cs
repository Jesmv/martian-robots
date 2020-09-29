using System;

public static class OrientationConverter
{
    public static float CardinalToDegrees(string orientation) {
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

    public static string DegreesToCardinal(float orientation) {
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