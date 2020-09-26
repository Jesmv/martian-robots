using System;

public class Robot {
    public float x;
    public float y;
    public float orientation;

    public Robot(float x, float y, float orientation){
        this.x = x;
        this.y = y;
        this.orientation = orientation;
    }

    public string getPosition(){
        return this.x + " " + this.y + " " + this.orientation;
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