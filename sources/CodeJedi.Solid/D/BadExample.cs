using System;

namespace CodeJedi.Solid.D
{
    public class Car_bad
    {
        public void GoTo(string destination)
        {
            Console.WriteLine($"Going to {destination}.");
        }
    }

    public class Driver_bad
    {
        private readonly Car_bad _car;

        public Driver_bad(Car_bad car)
        {
            _car = car;
        }

        public void GoBackHome()
        {
            _car.GoTo("Home");
        }
    }
}