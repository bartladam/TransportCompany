using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Newdays stations have digital information table, which us information about arrive transport vehicle
    /// </summary>
    internal class InformationTable
    {
        /// <summary>
        /// Calculate when transport vehicle arrive to station
        /// </summary>
        /// <param name="vehiclePosition"></param>
        /// <param name="positionStation"></param>
        /// <param name="speedVehicle"></param>
        /// <returns></returns>
        public double TimeToArrive(float vehiclePosition, float positionStation, int speedVehicle)
        {
            return Math.Round((double)((positionStation - vehiclePosition) / speedVehicle)*60);
        }
    }
}
