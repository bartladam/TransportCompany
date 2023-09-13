using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class Tram:Vehicle
    {
        public enum tramVagons {one, two};
        public tramVagons vagons { get; private set; }
        public Tram(string transportVehicle, int designationVehicle, int speedVehicle, tramVagons vagons) : base(transportVehicle,designationVehicle, speedVehicle)
        {
            this.vagons = vagons;
        }
        public override void GoVehicle(float distance)
        {
            placeVehicle += distance;
        }
        public override float GetInformation()
        {
            return placeVehicle;
        }

    }
}
