using System;

public class Robot {
    private int x;
    private int y;
    private string orientation;

    public Robot(int x, int y, string orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
    }

    public string printRobot(){
        return this.x + " " + this.y + " " + this.orientation;
    }

    public string rotate(string value){
        
        
        return "";
    }
}