using System;

namespace CodeJedi.Solid.L
{
    public class Car_good
    {
        public virtual void GoForward()
        {
            Console.WriteLine("Going forward");
        }

        public virtual void GoBackward()
        {
            Console.WriteLine("Going backward");
        }
    }

    public class Dragster_good
    {
        public virtual void GoForward()
        {
            Console.WriteLine("Going forward with dragster");
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

        public void DriveBackward()
        {
            _car.GoBackward();
        }
    }
}