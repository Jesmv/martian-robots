using System;

public class Planet {
    public int dx;
    public int dy;

    public Planet(int dx, int dy){
        this.dx = dx;
        this.dy = dy;
    }

    public string printPlanet(){
        return this.dx + " " + this.dy;
    }

    public void checkLimits(Robot robot){
        if (dx < robot.x){
            robot.x = dx;
            robot.lost = true;
        } else if(dy < robot.y){
            robot.y = dy;
            robot.lost = true;
        } else if (robot.x < 0) {
            robot.x = 0;
            robot.lost = true;
        } else if (robot.y < 0) {
            robot.y = 0;
            robot.lost = true;
        }
    }
} 