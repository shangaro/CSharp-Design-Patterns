namespace FactoryPattern.VehicleCreation
{
    public class Bike : IVehicle
    {
        public string type { get; set; } = "Bike";

        public string Drive(int miles)
        {
            return miles.ToString();
        }
    }

    

   

 
}

