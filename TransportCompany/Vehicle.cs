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
        public float placeVehicle { get; set; } // dej pak na protected
        public int speedVehicle { get; private set; }
        public string transportVehicle { get; private set; }
        public Vehicle(string transportVehicle, int designationVehicle, int speedVehicle)
        {
            this.transportVehicle = transportVehicle;
            this.designationVehicle = designationVehicle;
            this.speedVehicle = speedVehicle;
        }
        public abstract void GoVehicle(float distance);
        public abstract float GetInformation();
        public override string ToString()
        {
            return designationVehicle.ToString();
        }
    }
}
