using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public int CargoHoldSize { get; set; }
        public bool ThirdRowSeating { get; set; }
        public string CoName { get; set; }
        public string Logo { get; set; }
        public bool OffRoad { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int WheelCount { get; set; }
    }
}