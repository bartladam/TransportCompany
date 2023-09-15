using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Transport enterprise used transport vehicle for transport between stations
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        /// Designation vehicle helps passengers to deciding about transport to their target
        /// </summary>
        protected int designationVehicle { get; private set; }
        /// <summary>
        /// Current position vehicle. Used for calculate distance between vehicle and station
        /// </summary>
        protected float placeVehicle { get; set; } 
        /// <summary>
        /// Speed vehicle is important for time, when transport vehicle arrive to station
        /// </summary>
        public int speedVehicle { get; private set; }
        /// <summary>
        /// Type vehicle of transport helps passengers with choice best option to move to their target
        /// </summary>
        public enum typeTransportVehicle { Bus, Tram};
        public typeTransportVehicle type { get; private set; }

        public Vehicle(typeTransportVehicle type, int designationVehicle, int speedVehicle)
        {
            this.type = type;
            this.designationVehicle = designationVehicle;
            this.speedVehicle = speedVehicle;
        }
        /// <summary>
        /// Driver is moving on some route to next station
        /// </summary>
        /// <param name="distance"></param>
        public abstract void GoVehicle(float distance);
        /// <summary>
        /// Transport vehicle broadcasts his position on route
        /// </summary>
        /// <returns></returns>
        public abstract float GetInformation();
        public override string ToString()
        {
            return designationVehicle.ToString();
        }
    }
}
