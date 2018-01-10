using System;

namespace vehicles
{
    public class Motorcycle : Land, IWheels, IVehicle, IEngine, IPassengerCapacity
    {
        public double EngineVolume { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public int PassengerCapacity { get; set; }

        public void Drive()
        {
            Console.WriteLine("Do a wheelie!");
        }

        public void Start()
        {
            Console.WriteLine("Started up");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public Motorcycle(double engineVolume, string transMission, int passengerCapacity)
        {
            this.EngineVolume = engineVolume;
            this.TransmissionType = transMission;
            this.PassengerCapacity = passengerCapacity;
        }
    }
}