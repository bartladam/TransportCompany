using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class InformationTable
    {
        public float TimeToArrive(float vehiclePosition, float positionStation)
        {
            return vehiclePosition - positionStation;
        }
    }
}
