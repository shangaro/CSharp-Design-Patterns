using System;

namespace FactoryPattern.VehicleCreation
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle Create(string type)
        {
            switch (type)
            {
                case "bike": return new Bike();
                case "scooter": return new Scooter();
                default: throw new ArgumentException("invalid type", type);
            }
        }
    }

    

   

 
}

