using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Specific type of transport vehicle
    /// </summary>
    internal class Bus:Vehicle
    {
        /// <summary>
        /// On some routes is better short bus, on other middle or long bus
        /// </summary>
        public enum lengthBus { shortBus, middleBus, longBus};
        public lengthBus bus { get; private set; }
    
        public Bus(Vehicle.typeTransportVehicle type, int designationVehicle, lengthBus bus, int speedVehicle):base(type,designationVehicle, speedVehicle)
        {
            this.bus = bus;
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
