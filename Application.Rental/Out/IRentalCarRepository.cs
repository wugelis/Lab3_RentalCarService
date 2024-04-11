using Domain.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Rental.Out
{
    //port/Out
    /// <summary>
    /// IRepository 介面：對租車系統的外部 Infrastructure 的操作
    /// </summary>
    public interface IRentalCarRepository
    {
        /// <summary>
        /// 確認租車
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        int SaveRentalCar(IVehicle vehicle);
    }
}
