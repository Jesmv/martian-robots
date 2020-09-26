using System;

public class Robot {
    public float x;
    public float y;
    public string orientation;
    public float degrees;

    public Robot(int x, int y, string orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
        this.degrees = cardinalToDegrees(orientation);
    }

    public string printRobot(){
        return this.x + " " + this.y + " " + this.orientation;
    }

    public void rotate(string value){
        
        switch (this.orientation)
        {
            case "N":
                if (value=="L") this.orientation = "W";
                if (value=="R") this.orientation = "E";
                break;
            case "E":
                if (value=="L") this.orientation = "N";
                if (value=="R") this.orientation = "S";
                break;
            case "S":
                if (value=="L") this.orientation = "E";
                if (value=="R") this.orientation = "W";
                break;
            case "W":
                if (value=="L") this.orientation = "S";
                if (value=="R") this.orientation = "N";
                break;
        }
    }

    public float cardinalToDegrees(string orientation) {
        if (orientation == "N") return 0;
        if (orientation == "E") return 90;
        if (orientation == "S") return 180;
        if (orientation == "W") return 270;

        return 360;
    }

    public string degreesToCardinal(float degrees) {
        if (degrees == 0) return "N";
        if (degrees == 90) return "E";
        if (degrees == 180) return "S";
        if (degrees == 270) return "W";

        return string.Empty;
    }
}