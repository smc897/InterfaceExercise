using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany done

            //Create 3 classes called Car , Truck , & SUV done

            //In your IVehicle done

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany done

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes done

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; done
            //Creatively display and organize their values
            var car = new Car()
            {
                TrunkOpen = true,
                IsSedan = true,
                NumberofCylinders = 8,
                NumberOfDoors = 4,
                Color = "blue",
                WheelSize = 32,
                Name = "honda",
                Logo = "scarf"
            };

            var suv = new Suv()
            {
                FloorColor="grey",
                LidOpen=false,
                NumberofCylinders = 8,
                NumberOfDoors = 4,
                Color = "blue",
                WheelSize = 32,
                Name = "honda",
                Logo = "scarf"
            };

            var truck = new Truck()
            {
                BedColor="black",
                ExtendedCab=true,
                NumberofCylinders = 8,
                NumberOfDoors = 4,
                Color = "blue",
                WheelSize = 32,
                Name = "honda",
                Logo = "scarf"
            };

            List<IVehicle> l = new List<IVehicle>();
            l.Add(car);
            l.Add(truck);
            l.Add(suv);
            foreach (var v in l) {
                Console.WriteLine($"Number of Cylinders: {v.NumberofCylinders}");
                Console.WriteLine($"Name: {v.Name}");
                Console.WriteLine($"Color: {v.Color}");
                Console.WriteLine($"Logo: {v.NumberOfDoors}");
                Console.WriteLine($"Wheel size: {v.WheelSize}");
            }
        }
    }
}
