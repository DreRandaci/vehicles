using System;

namespace vehicles
{
    public class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
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