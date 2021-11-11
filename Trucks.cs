using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {

        public int TruckBedSize { get; set; }
        public bool HasTrailerHitch { get; set; }
        public string CoName { get; set; }
        public string Logo { get; set; }
        public bool OffRoad { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int WheelCount { get; set; }
    }
}