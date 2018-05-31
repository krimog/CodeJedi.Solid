namespace CodeJedi.Solid.I
{
    public interface IVehicle_good
    {
        void GoTo(string destination);
    }

    public interface IEngineObject_good
    {
        void StartEngine();
    }

    public interface IEngineVehicle_good : IVehicle_good, IEngineObject_good
    {
    }

    public class Car_good : IEngineVehicle_good
    {
        public void GoTo(string destination)
        {
        }

        public void StartEngine()
        {
        }
    }

    public class Motorbike_good : IEngineVehicle_good
    {
        public void GoTo(string destination)
        {
        }

        public void StartEngine()
        {
        }
    }

    public class Bicycle_good : IVehicle_good
    {
        public void GoTo(string destination)
        {
        }
    }
}