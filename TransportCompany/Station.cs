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
        public int positionStation { get; private set; }
        public Station(string nameStation,int positionStation, InformationTable table)
        {
            this.nameStation = nameStation;
            this.positionStation = positionStation;
            this.table = table;
        }
        public float TimeToArrive(Vehicle vehicle)
        {
            return table.TimeToArrive(vehicle.GetInformation(),positionStation);
        }

    }
}
