using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class Station
    {
        public string nameStation { get; private set; }
        public InformationTable table { get; private set; }
        /// <summary>
        /// Position by start route
        /// </summary>
        public float positionStation { get; private set; }
        public Station(string nameStation,float positionStation, InformationTable table)
        {
            this.nameStation = nameStation;
            this.positionStation = positionStation;
            this.table = table;
        }
        public double TimeToArrive(Vehicle vehicle)
        {
            return table.TimeToArrive(vehicle.GetInformation(),positionStation, vehicle.speedVehicle);
        }
        public override string ToString()
        {
            return nameStation;
        }

    }
}
