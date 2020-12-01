using Aircompany.Models;
using Aircompany.Models.Planes;
using Aircompany.Models.Planes.PlaneTypes;
using AirCompany.Data;
using System;
using System.Collections.Generic;

namespace Aircompany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var planes = PlanesStorage.GetPlanes();
            Airport airport = new Airport(planes);


            Airport militaryAirport = new Airport(airport.GetMilitaryPlanes());
            Airport passengerAirport = new Airport(airport.GetPassengerPlanes());

            Console.WriteLine(militaryAirport
                .SortByMaxDistance()
                .ToString());

            Console.WriteLine(passengerAirport
                .SortByMaxSpeed()
                .ToString());

            Console.WriteLine(passengerAirport
                .GetPlaneWithMaxCapacity());
        }
    }
}