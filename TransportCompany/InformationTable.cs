using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class InformationTable
    {
        public double TimeToArrive(float vehiclePosition, float positionStation, int speedVehicle)
        {
            return Math.Round((double)((positionStation - vehiclePosition) / speedVehicle)*60);
        }
    }
}
