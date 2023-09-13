using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class TransportEnterprise
    {
        public string NameTransportEnterprise { get; private set; }
        public List<Route> routes { get; private set; }
        public TransportEnterprise(string NameTransportEnterprise)
        {
            this.NameTransportEnterprise = NameTransportEnterprise;
            routes = new List<Route>();
        }
        public void newRoute(string nameRoute, Vehicle vehicle, params Station[] stations)
        {
            routes.Add(new Route(nameRoute, vehicle, stations));
        }


    }
}
