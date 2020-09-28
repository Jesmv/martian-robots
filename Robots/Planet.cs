using System;
using System.Collections.Generic;

public class Planet {
    public int dx;
    public int dy;

    public List<(float, float)> scents = new List<(float, float)>();

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

        if(robot.lost) {
            if (scents.Exists(x => x == (robot.x, robot.y))){
                robot.lost = false;
            } else {
                scents.Add((robot.x, robot.y));
            }
        }
        
    }
} 