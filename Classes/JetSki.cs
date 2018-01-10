using System;

namespace vehicles
{
    public class JetSki : IVehicle, IAquatic, IPassengerCapacity
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }    
        public double MaxWaterSpeed { get; set; }
        public JetSki(int _passengerCapacity, string _transmissionType, double _engineVolume, double _maxWaterSpeed)
        {
            this.PassengerCapacity = _passengerCapacity;
            this.TransmissionType = _transmissionType;
            this.EngineVolume = _engineVolume;
            this.MaxWaterSpeed = _maxWaterSpeed;
        }

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