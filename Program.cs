using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values



            //SUVs
            var firstSuv = new SUV();

            firstSuv.CoName = "Nissian";
            firstSuv.Model = "Rougue";
            firstSuv.Year = 2016;
            firstSuv.Logo = "an 'Nissian' inside the Circle";
            firstSuv.ThirdRowSeating = false;
            firstSuv.CargoHoldSize = 10;
            firstSuv.WheelCount = 4;
            firstSuv.OffRoad = true;

            var secondSuv = new SUV();

            secondSuv.CoName = "Chevrolet";
            secondSuv.Model = "Spark LS";
            secondSuv.Year = 2018;
            secondSuv.Logo = "the Chevrolet logo";
            secondSuv.ThirdRowSeating = true;
            secondSuv.CargoHoldSize = 5;
            secondSuv.WheelCount = 4;
            secondSuv.OffRoad = true;

            //Trucks
            var firstTruck = new Truck();

            firstTruck.CoName = " Chevrolet";
            firstTruck.Model = "Silverado";
            firstTruck.Year = 2021;
            firstTruck.Logo = "the Chevrolet logo";
            firstTruck.TruckBedSize = 18;
            firstTruck.HasTrailerHitch = true;
            firstTruck.WheelCount = 4;
            firstTruck.OffRoad = true;

            var secondTruck = new Truck();

            secondTruck.CoName = "RAM";
            secondTruck.Model = "1500";
            secondTruck.Year = 2018;
            secondTruck.Logo = "Ram written on the front";
            secondTruck.TruckBedSize = 22;
            secondTruck.HasTrailerHitch = true;
            secondTruck.WheelCount = 4;
            secondTruck.OffRoad = true;

            //Cars
            var firstCar = new Car();

            firstCar.CoName = "Nissian";
            firstCar.Model = "Maxium";
            firstCar.Year = 2010;
            firstCar.Logo = "Nissian";
            firstCar.TrunkSize = 12;
            firstCar.IsConvertable = true;
            firstCar.WheelCount = 4;
            firstCar.OffRoad = false;

            var secondCar = new Car();

            secondCar.CoName = "Ford";
            secondCar.Model = "Fusion";
            secondCar.Year = 2011;
            secondCar.Logo = "Ford";
            secondCar.TrunkSize = 10;
            secondCar.IsConvertable = false;
            secondCar.WheelCount = 4;
            secondCar.OffRoad = false;


            var vehicles = new List<IVehicle>();

            vehicles.Add(firstSuv);
            vehicles.Add(secondSuv);
            vehicles.Add(firstTruck);
            vehicles.Add(secondTruck);
            vehicles.Add(firstCar);
            vehicles.Add(secondCar);

            var suvs = new List<SUV>();
            var trucks = new List<Truck>();
            var cars = new List<Car>();

            suvs.Add(firstSuv);
            suvs.Add(secondSuv);

            trucks.Add(firstTruck);
            trucks.Add(secondTruck);

            cars.Add(firstCar);
            cars.Add(secondCar);


            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"The name of this vehicle is '{vehicle.CoName} {vehicle.Model}' and it was made in the year {vehicle.Year}. This vehicle has {vehicle.WheelCount} wheels.\n " +
                    $"It is {vehicle.OffRoad} that this vehilce can go off-road.");
            }

            foreach (var suv in suvs)
            {
                Console.WriteLine($"The {suv.Model} has {suv.CargoHoldSize} cubic square feet in the cargo area. It is {suv.ThirdRowSeating} that it has third row seating.");

            }

            foreach (var truck in trucks)
            {
                Console.WriteLine($"The {truck.Model} has {truck.TruckBedSize} cubic square feet in the truck bed. It is {truck.HasTrailerHitch} that it has a trailer hitch.");

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"The {car.Model} has {car.TrunkSize} cubic square feet in the trunk. It is {car.IsConvertable} that it is a convertable.");

            }





        }
    }
}