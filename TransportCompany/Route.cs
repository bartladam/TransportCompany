using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    internal class Route
    {
        public string nameRoute { get; private set; }
        public Vehicle vehicle { get; private set; }
        public List<Station> stations { get; private set; }

        public Route(string nameRoute, Vehicle vehicle, Station[] stations)
        {
            this.nameRoute = nameRoute;
            this.vehicle = vehicle;
            this.stations = new List<Station>(stations);
        }


    }
}
