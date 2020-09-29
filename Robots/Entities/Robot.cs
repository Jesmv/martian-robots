using System;
using System.Text;

public class Robot 
{
    public float x;
    public float y;
    public float orientation;
    public Boolean lost = false;

    public Robot(float x, float y, float orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
    }

    public string GetPosition(){
        StringBuilder builder = new StringBuilder(); 
        builder.Append(x).Append(" ").Append(y).Append(" ").Append(OrientationConverter.degreesToCardinal(orientation));
        if (lost) builder.Append(" ").Append("LOST");

        return builder.ToString();
    }
}