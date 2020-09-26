using System;

public class Robot {
    public float x;
    public float y;
    public string orientation;
    public float degrees;

    public Robot(float x, float y, string orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
        this.degrees = cardinalToDegrees(orientation);
    }

    public string printRobot(){
        return this.x + " " + this.y + " " + this.orientation;
    }

    public void moveLeft() {
        
        if (this.degrees == 0 || this.degrees == 45) {
            this.degrees += 270;
        } else {
            this.degrees -= 90;
        }
    }

    public void moveRight() {

        if (this.degrees == 270 || this.degrees == 315) {
            this.degrees -= 270;
        } else {
            this.degrees += 90;
        }
    }

    public void moveForward() {
        switch (this.orientation)
        {   case "N":
                this.y +=1;
                break;
            case "E":
                this.x +=1;
                break;
            case "S":
                this.y -=1;
                break;
            case "W":
                this.x -=1;
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