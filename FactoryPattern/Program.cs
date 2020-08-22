using FactoryPattern.ProductCreation;
using FactoryPattern.VehicleCreation;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcreteCreator();
            IProduct productA = factory.FactoryMethod("A");
            IProduct productB = factory.FactoryMethod("B");

            Console.WriteLine(productA.Name);
            Console.WriteLine(productB.Name);

            // vehicleFactory
            VehicleFactory vehicleFactory = new ConcreteVehicleFactory();
            Bike bike = (Bike)vehicleFactory.Create("bike");
            Scooter scooter = (Scooter)vehicleFactory.Create("scooter");
            //Vehicle van = vehicleFactory.Create("van");
            Console.WriteLine($"{nameof(bike)} drives {bike.Drive(30)} miles");
            Console.WriteLine($"{nameof(scooter)} drives {scooter.Drive(40)} miles");


        }
    }

    

   

 
}

