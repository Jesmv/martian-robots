using System;

public class Robot {
    public int x;
    public int y;
    public string orientation;

    public Robot(int x, int y, string orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
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
}