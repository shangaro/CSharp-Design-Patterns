using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroFactory = new HeroFactory();
            var hondaFactory = new HondaFactory();
            var client1 = new VehicleClient(heroFactory, "Regular");
            var client2 = new VehicleClient(heroFactory, "Sports");
            var client3 = new VehicleClient(hondaFactory, "Regular");
            var client4 = new VehicleClient(hondaFactory, "Sports");

            Console.WriteLine("*******************Hero*************");
            Console.WriteLine(client1.GetBikeName());
            Console.WriteLine(client1.GetScooterName());
            Console.WriteLine(client2.GetBikeName());
            Console.WriteLine(client2.GetScooterName());

            Console.WriteLine("*******************Honda*************");
            Console.WriteLine(client3.GetBikeName());
            Console.WriteLine(client3.GetScooterName());
            Console.WriteLine(client4.GetBikeName());
            Console.WriteLine(client4.GetScooterName());


        }
    }

    internal interface IBike
    {
        string GetName();
    }
    internal interface IScooter
    {
        string GetName();
    }

    internal class SportsBike : IBike
    {
        public string GetName()
        {
            return "Sports Bike Name";
        }
    }
    internal class RegularBike : IBike
    {
        public string GetName()
        {
            return "Regular Bike's name";
        }
    }

    internal class RegularScooter : IScooter
    {
        public string GetName()
        {
            return "Regular Scooter's name";
        }
    }
    internal class Scooty : IScooter
    {
        public string GetName()
        {
            return "Scooty's name";
        }
    }


    internal interface IVehicleFactory
    {
        IBike GetBike(string type);
        IScooter GetScooter(string type);
        
    }

    internal class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string type)
        {
            return type switch
            {
                "Regular" => new RegularBike(),
                "Sports" => new SportsBike(),
                _ => throw new ArgumentException("invalid type", type),
            };
        }

        public IScooter GetScooter(string type)
        {
            return type switch
            {
                "Regular" => new RegularScooter(),
                "Sports" => new Scooty(),
                _ => throw new ArgumentException("invalid type", type)
            };
        }
    }

    internal class HeroFactory : IVehicleFactory
    {
        public IBike GetBike(string type)
        {
            return type switch
            {
                "Regular" => new RegularBike(),
                "Sports" => new SportsBike(),
                _ => throw new ArgumentException("invalid type", type),
            };
        }


        public IScooter GetScooter(string type)
        {
            return type switch
            {
                "Regular" => new RegularScooter(),
                "Sports" => new Scooty(),
                _ => throw new ArgumentException("invalid type", type)
            };
        }
    }

    internal class VehicleClient
    {
        private IBike _bike;
        private IScooter _scooter;

        internal VehicleClient(IVehicleFactory factory,string type)
        {
            _bike = factory.GetBike(type);
            _scooter = factory.GetScooter(type);
        }
        internal string GetBikeName() => _bike.GetName();
        internal string GetScooterName() => _scooter.GetName();
    }


}
