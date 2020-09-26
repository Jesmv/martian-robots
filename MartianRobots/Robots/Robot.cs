using System;
using System.Text;

public class Robot {
    public float x;
    public float y;
    public float orientation;
    public Boolean lost = false;

    public Robot(float x, float y, float orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
    }

    public string getPosition(){
        StringBuilder builder = new StringBuilder(); 
        builder.Append(x).Append(" ").Append(y).Append(" ").Append(orientation);
        if (lost) builder.Append(" ").Append("LOST");

        return builder.ToString();
    }

    public void rotateLeft() {
        
        if (this.orientation < 90) {
            this.orientation += 270;
        } else {
            this.orientation -= 90;
        }
    }

    public void rotateRight() {

        if (this.orientation >= 270) {
            this.orientation -= 270;
        } else {
            this.orientation += 90;
        }
    }

    public void moveForward() {
        switch (this.orientation)
        {   case 0:
                this.y +=1;
                break;
            case 90:
                this.x +=1;
                break;
            case 180:
                this.y -=1;
                break;
            case 270:
                this.x -=1;
                break;
        }
    }

}