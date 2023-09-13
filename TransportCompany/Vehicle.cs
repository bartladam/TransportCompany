using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    abstract class Vehicle
    {
        protected int designationVehicle { get; private set; }
        protected float placeVehicle { get; set; }
        public int speedVehicle { get; private set; }
        public Vehicle(int designationVehicle, int speedVehicle)
        {
            this.designationVehicle = designationVehicle;
            this.speedVehicle = speedVehicle;
        }
        public abstract void GoVehicle();
        public abstract float GetInformation();
    }
}
