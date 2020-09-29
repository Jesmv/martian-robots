public class MoveForward : IMovement 
{
    public void Move(Robot robot) {
        switch (robot.orientation)
        {   case 0:
                robot.y +=1;
                break;
            case 90:
                robot.x +=1;
                break;
            case 180:
                robot.y -=1;
                break;
            case 270:
                robot.x -=1;
                break;
        }
    }
}