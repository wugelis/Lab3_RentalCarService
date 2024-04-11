using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rental
{
    public class RV : IVehicle
    {
        public string Name => "RAV4";
        public decimal CalculateRentalCost(int daysRented)
        {
            return 150 * daysRented;
        }

        public VehicleType GetVehicleType() => VehicleType.RV;
    }
}
