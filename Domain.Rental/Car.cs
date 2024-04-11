namespace Domain.Rental
{
    public class Car : IVehicle
    {
        public string Name => "Camry";
        public decimal CalculateRentalCost(int daysRented)
        {
            return 120 * daysRented;
        }

        public VehicleType GetVehicleType() => VehicleType.Car;
    }
}
