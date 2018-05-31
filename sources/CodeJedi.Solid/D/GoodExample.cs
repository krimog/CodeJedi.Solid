using System;

namespace CodeJedi.Solid.D
{
    public interface IVehicle_good
    {
        void GoTo(string destination);
    }

    public class Car_good : IVehicle_good
    {
        public void GoTo(string destination)
        {
            Console.WriteLine($"Going to {destination}.");
        }
    }

    public class Driver_good
    {
        private readonly IVehicle_good _vehicle;

        public Driver_good(IVehicle_good vehicle)
        {
            _vehicle = vehicle;
        }

        public void GoBackHome()
        {
            _vehicle.GoTo("Home");
        }
    }
}