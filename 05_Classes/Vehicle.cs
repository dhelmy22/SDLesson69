using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Boat, Rocket, Hovercraft, Submarine};
    public class Vehicle
    {
        public string Make { get; set; }
        private string _model;

        public void SetModel(string model)
        {
            if (model == model.ToLower())
            {
                //capitalize
            }

            _model = model;
        }

        public string GetModel()
        {
            
            return _model;
        }

        public double Mileage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        // empty constructor
        public Vehicle()
        {

        }
        // Full constructor
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            _model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
        // Partial Constructor
        public Vehicle (VehicleType type, string model)
        {
            TypeOfVehicle = type;
            _model = model;
        }
        


    }
}
