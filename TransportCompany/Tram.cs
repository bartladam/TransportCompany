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
        public Tram(int designationVehicle, int speedVehicle, tramVagons vagons) : base(designationVehicle, speedVehicle)
        {
            this.vagons = vagons;
        }
        public override string GetInformation()
        {
            return designationVehicle.ToString() + placeVehicle.ToString();
        }
    }
}
