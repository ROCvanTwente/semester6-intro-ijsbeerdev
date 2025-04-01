namespace CSHARP_02.Models
{
    // Gemaakt door Hugo
    public interface IVehicle
    {
        int Speed { get; set; }
        int Wheels { get; set; }
        string Color { get; set; }

        void Accelerate();
        void Decelerate();
        string ShowSpeed();
    }

    public class Car : IVehicle
    {
        public int Speed { get; set; } = 0;
        public int Wheels { get; set; } = 4;
        public string Color { get; set; } = "Red";

        public void Accelerate() => Speed += 10;
        public void Decelerate() => Speed -= 5;
        public string ShowSpeed() => $"Current speed: {Speed} km/h";
    }

    public class Bicycle : IVehicle
    {
        public int Speed { get; set; } = 0;
        public int Wheels { get; set; } = 2;
        public string Color { get; set; } = "Blue";

        public void Accelerate() => Speed += 2;
        public void Decelerate() => Speed -= 1;
        public string ShowSpeed() => $"Current speed: {Speed} km/h";
    }

}
