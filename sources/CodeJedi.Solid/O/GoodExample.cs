namespace CodeJedi.Solid.O
{
    public abstract class Car_good
    {
        public abstract void GoForward();
    }

    public class FuelCar_good : Car_good
    {
        public override void GoForward()
        {
        }
    }

    public class DieselCar_good : Car_good
    {
        public override void GoForward()
        {
        }
    }

    public class Driver_good
    {
        private readonly Car_good _car;

        public Driver_good(Car_good car)
        {
            _car = car;
        }

        public void DriveForward()
        {
            _car.GoForward();
        }
    }
}