using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Suv: IVehicle
    { 
        public String FloorColor { get; set; }
        public bool LidOpen { get; set; }
        public int NumberofCylinders { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public double WheelSize { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
