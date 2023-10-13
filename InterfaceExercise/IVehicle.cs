using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle: ICompany
    {
        public int NumberofCylinders { get; set; }
        public int NumberOfDoors { get; set; }
        public String Color { get; set; }
        public double WheelSize { get; set; }
    }
}
