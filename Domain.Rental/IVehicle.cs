using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rental
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVehicle
    {
        string Name { get; }
        VehicleType GetVehicleType();
        decimal CalculateRentalCost(int daysRented);
    }
}
