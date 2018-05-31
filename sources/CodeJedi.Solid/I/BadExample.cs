namespace CodeJedi.Solid.I
{
    public interface IVehicle_bad
    {
        void GoTo(string destination);

        void StartEngine();
    }

    public class Car_bad : IVehicle_bad
    {
        public void GoTo(string destination)
        {
        }

        public void StartEngine()
        {
        }
    }

    public class Motorbike_bad : IVehicle_bad
    {
        public void GoTo(string destination)
        {
        }

        public void StartEngine()
        {
        }
    }

    public class Bicycle_bad
    {
        public void GoTo(string destination)
        {
        }
    }
}