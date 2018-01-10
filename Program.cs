using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Program
    {

        public static void Main()
        {
            // Build a collection of all vehicles that fly

            List<Flying> flyingVehicles = new List<Flying>();

            FlyingJetSki flyingJetSki = new FlyingJetSki(2, "Automatic", 70.5, 200);
            Cessna flyingCessna = new Cessna(3, 2, 2, true, "Automatic", 100.25, 100, 150);            
            flyingVehicles.Add(flyingJetSki);
            flyingVehicles.Add(flyingCessna);

            // With a single `foreach`, have each vehicle Fly()

            foreach (Flying flying in flyingVehicles)
            {
                flying.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            List<Land> landVehicles = new List<Land>();

            Motorcycle moto = new Motorcycle(80, "Manual", 2);            

            landVehicles.Add(moto);


            // With a single `foreach`, have each road vehicle Drive()
            foreach (Motorcycle bike in landVehicles)
            {
                bike.Drive();
            } 

            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }

    }
}