using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class Bus:Vehicle
    {
        public enum lengthBus { shortBus, middleBus, longBus};
        public lengthBus bus { get; private set; }
    
        public Bus(string transportVehicle, int designationVehicle, lengthBus bus, int speedVehicle):base(transportVehicle,designationVehicle, speedVehicle)
        {
            this.bus = bus;
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
