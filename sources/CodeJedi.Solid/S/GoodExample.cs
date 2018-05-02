namespace CodeJedi.Solid.S
{
    public class CarMovement_good
    {
        public void GoForward()
        {
        }

        public void GoBackward()
        {
        }

        public void TurnLeft()
        {
        }
    }

    public class CarAppearance_good
    {
        public void ChangeColor(byte r, byte g, byte b)
        {
        }
    }

    public class Car_good
    {
        public CarMovement_good Movement { get; }
        public CarAppearance_good Appearance { get; }
    }
}
