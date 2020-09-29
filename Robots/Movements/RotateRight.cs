public class RotateRight : IMovement
{
    public void Move(Robot robot)
    {
        if (robot.orientation >= 270) {
            robot.orientation -= 270;
        } else {
            robot.orientation += 90;
        }
    }
}