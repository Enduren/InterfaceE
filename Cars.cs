using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public int TrunkSize { get; set; }
        public bool IsConvertable { get; set; }
        public string CoName { get; set; }
        public string Logo { get; set; }
        public bool OffRoad { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int WheelCount { get; set; }
    }
}