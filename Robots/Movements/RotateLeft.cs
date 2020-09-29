public class RotateLeft : IMovement
{
    public void Move(Robot robot)
    {
        if (robot.orientation < 90) {
            robot.orientation += 270;
        } else {
            robot.orientation -= 90;
        }
    }
}
