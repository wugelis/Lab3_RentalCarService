using Domain.Rental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Rental.In
{
    /// <summary>
    /// Port/In: WebRequest 查詢租車的相關資料
    /// </summary>
    public class RentalCarRequest
    {
        /// <summary>
        /// 租車的天數
        /// </summary>
        public int daysRented { get; set; }
        /// <summary>
        /// 要進行租車的車型
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VehicleType vehicleType { get; set; }
    }
}
