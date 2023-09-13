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
    
        public Bus(int designationVehicle, lengthBus bus, int speedVehicle):base(designationVehicle, speedVehicle)
        {
            this.bus = bus;
        }
        public override void GoVehicle()
        {
            placeVehicle += 10;
        }
        public override float GetInformation()
        {
            return placeVehicle;
        }

    }
}
