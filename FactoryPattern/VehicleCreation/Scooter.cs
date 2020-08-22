namespace FactoryPattern.VehicleCreation
{
    public class Scooter : IVehicle
    {
        public string type { get; set; } = "Scooter";

        public string Drive(int miles)
        {
            return miles.ToString();
        }
    }

    

   

 
}

