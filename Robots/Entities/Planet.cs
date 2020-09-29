using System;
using System.Collections.Generic;

public class Planet 
{
    public float x;
    public float y;
    public List<(float, float)> scents = new List<(float, float)>();

    public Planet(float x, float y){
        this.x = x;
        this.y = y;
    }

    public string PrintPlanet(){
        return this.x + " " + this.y;
    }

    public void CheckLimits(Robot robot){
        if (x < robot.x){
            robot.x =x;
            robot.lost = true;
        } else if(y < robot.y){
            robot.y = y;
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