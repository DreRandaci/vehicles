using System;

namespace vehicles
{
    public class Cessna : Flying, IVehicle, IEngine, IPassengerCapacity, IWheels, IWinged, IDoors
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 309.0;        

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

        public Cessna(int _wheels, int _doors, int _passengerCapacity, bool _winged, string _transmissionType, double _engineVolume, double _maxLandSpeed, double _maxAirSpeed)
        {
            this.Wheels = _wheels;
            this.Doors = _doors;
            this.PassengerCapacity = _passengerCapacity;
            this.Winged = _winged;
            this.TransmissionType = _transmissionType;
            this.EngineVolume = _engineVolume;
            this.MaxLandSpeed = _maxLandSpeed;
            this.MaxAirSpeed = _maxAirSpeed;
        }        
    }
}