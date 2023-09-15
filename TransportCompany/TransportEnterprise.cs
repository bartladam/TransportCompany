using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    /// <summary>
    /// Transport enterprise manage public transport in city
    /// </summary>
    internal class TransportEnterprise
    {
        /// <summary>
        /// Name of whole organization which is providing transport service
        /// </summary>
        public string NameTransportEnterprise { get; private set; }
        /// <summary>
        /// Organization have builded X routes to transport passenger from place A to B
        /// For example in Prague subway we have 3 routes: A, B, C
        /// </summary>
        public List<Route> routes { get; private set; }
        public TransportEnterprise(string NameTransportEnterprise)
        {
            this.NameTransportEnterprise = NameTransportEnterprise;
            routes = new List<Route>();
        }
        /// <summary>
        /// Organization can build new route to better connection with current routes
        /// </summary>
        /// <param name="nameRoute"></param>
        /// <param name="vehicle"></param>
        /// <param name="stations"></param>
        public void newRoute(string nameRoute, Vehicle vehicle, params Station[] stations)
        {
            routes.Add(new Route(nameRoute, vehicle, stations));
        }


    }
}
