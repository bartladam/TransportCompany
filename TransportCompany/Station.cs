using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Place when transport vehicle have to stop
    /// </summary>
    internal class Station
    {
        /// <summary>
        /// Passenger have to knows his location at the moment
        /// </summary>
        public string nameStation { get; private set; }
        /// <summary>
        /// Each newdays station has digital information table about arive time transport vehicle
        /// </summary>
        public InformationTable table { get; private set; }
        /// <summary>
        /// Position station is important to calculate time when transport vehicle arrive. 
        /// For example: position station is 40 km from start station
        /// </summary>
        public float positionStation { get; private set; }
        public Station(string nameStation,float positionStation, InformationTable table)
        {
            this.nameStation = nameStation;
            this.positionStation = positionStation;
            this.table = table;
        }
        /// <summary>
        /// Used for calculate when transport vehicle arrive to station
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
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
