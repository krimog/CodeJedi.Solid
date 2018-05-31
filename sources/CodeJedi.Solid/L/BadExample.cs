using System;

namespace CodeJedi.Solid.L
{
    public class Car_bad
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

    public class Dragster_bad : Car_bad
    {
        public override void GoForward()
        {
            Console.WriteLine("Going forward with dragster");
        }

        public override void GoBackward()
        {
            throw new NotSupportedException("Dragsters can't go backward");
        }
    }

    public class Driver_bad
    {
        private readonly Car_bad _car;

        public Driver_bad(Car_bad car)
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