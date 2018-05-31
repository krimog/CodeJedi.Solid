using System;

namespace CodeJedi.Solid.O
{
    public abstract class Car_bad
    {
    }

    public class FuelCar_bad : Car_bad
    {
        public void GoForwardWithFuelEngine()
        {
        }
    }

    public class DieselCar_bad : Car_bad
    {
        public void GoForwardWithDieselEngine()
        {
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
            switch(_car)
            {
                case DieselCar_bad dc:
                    dc.GoForwardWithDieselEngine();
                    break;
                case FuelCar_bad fc:
                    fc.GoForwardWithFuelEngine();
                    break;
                default:
                    throw new NotSupportedException("This car type is not supported.");
            }
        }
    }
}