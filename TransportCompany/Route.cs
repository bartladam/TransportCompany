using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Transport enterprise has a lot of routes where they can transport passengers across city
    /// </summary>
    internal class Route
    {
        /// <summary>
        /// Name route is important for clarity whole system
        /// </summary>
        public string nameRoute { get; private set; }
        /// <summary>
        /// Transport between station is provided by transport vehicle
        /// </summary>
        public Vehicle vehicle { get; private set; }
        /// <summary>
        /// Route has a lot of stations where transport vehicle must stop
        /// </summary>
        public List<Station> stations { get; private set; }

        public Route(string nameRoute, Vehicle vehicle, Station[] stations)
        {
            this.nameRoute = nameRoute;
            this.vehicle = vehicle;
            this.stations = new List<Station>(stations);
        }


    }
}
