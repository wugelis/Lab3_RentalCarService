using Domain.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Rental.In
{
    // port/In
    /// <summary>
    /// 應用層：查詢租車系統的所有車輛
    /// </summary>
    public interface IQueryRentalCarUserCase
    {
        /// <summary>
        /// 取得所有車輛
        /// </summary>
        /// <returns></returns>
        IEnumerable<IVehicle> GetAllCars();
    }
}
