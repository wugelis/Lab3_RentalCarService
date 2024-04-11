using Application.Rental.In;
using Application.Rental.Out;
using Domain.Rental;

namespace Infrastructure.Rental
{
    public class RentalCarRepository : IRentalCarRepository, IQueryRentalCarUserCase
    {
        private List<IVehicle> _vehicles;
        public RentalCarRepository() 
        { 
            _vehicles = new List<IVehicle>();
            _vehicles.Add(new Car());
            _vehicles.Add(new RV());
        }
        public IEnumerable<IVehicle> GetAllCars()
        {
            return _vehicles;
        }

        public int SaveRentalCar(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
