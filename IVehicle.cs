using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool OffRoad { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int WheelCount { get; set; }

        public string CoName { get; set; }




    }
}