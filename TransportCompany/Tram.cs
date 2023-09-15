using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    ///  Specific type of transport vehicle
    /// </summary>
    internal class Tram:Vehicle
    {
        /// <summary>
        /// Some transport links use shorter vehicle, because the links are not too busy
        /// </summary>
        public enum tramVagons {one, two};
        public tramVagons vagons { get; private set; }
        public Tram(Vehicle.typeTransportVehicle type, int designationVehicle, int speedVehicle, tramVagons vagons) : base(type,designationVehicle, speedVehicle)
        {
            this.vagons = vagons;
        }
        /// <summary>
        /// Driver is moving on some route to next station
        /// </summary>
        /// <param name="distance"></param>
        public override void GoVehicle(float distance)
        {
            placeVehicle += distance;
        }
        /// <summary>
        /// Transport vehicle broadcasts his position on route
        /// </summary>
        /// <returns></returns>
        public override float GetInformation()
        {
            return placeVehicle;
        }

    }
}
