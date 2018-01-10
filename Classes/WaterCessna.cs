using System;

namespace vehicles
{
    public class WaterCessna : Flying, IVehicle, IAquatic, IEngine, IPassengerCapacity, IDoors
    {
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 309.0;
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