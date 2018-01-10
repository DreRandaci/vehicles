using System;

namespace vehicles
{
    public class WaterMotorcycle : IVehicle, IAquatic, IEngine, IPassengerCapacity
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}