using System;

public class Planet {
    private int dx;
    private int dy;

    public Planet(int dx, int dy){
        this.dx = dx;
        this.dy = dy;
    }

    public string printPlanet(){
        return this.dx + " " + this.dy;
    }
} 