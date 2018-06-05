using System;

namespace CodeJedi.Solid.O
{
    public abstract class Car_bad
    {
    }

    public class GasCar_bad : Car_bad
    {
        public void GoForwardWithGasEngine()
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
                case GasCar_bad fc:
                    fc.GoForwardWithGasEngine();
                    break;
                default:
                    throw new NotSupportedException("This car type is not supported.");
            }
        }
    }
}