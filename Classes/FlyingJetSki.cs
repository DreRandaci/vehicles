using System;

namespace vehicles
{
    public class FlyingJetSki : Flying, IVehicle, IPassengerCapacity
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }    
        public double MaxAirSpeed { get; set; } = 300;

        public void Drive()
        {
            Console.WriteLine("Jetski is driving");
        }

        public void Start()
        {
            Console.WriteLine("Jetski has started");
        }

        public void Stop()
        {
            Console.WriteLine("Jetski has stopped");
        }

        public FlyingJetSki(int _passengerCapacity, string _transmissionType, double _engineVolume, double _maxAirSpeed)
        {
            this.PassengerCapacity = _passengerCapacity;
            this.TransmissionType = _transmissionType;
            this.EngineVolume = _engineVolume;
            this.MaxAirSpeed = _maxAirSpeed;
        }        
    }
}