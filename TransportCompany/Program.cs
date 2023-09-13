
using TransportCompany;

TransportEnterprise transport = new TransportEnterprise("MHD Prague");
transport.newRoute("A", new Bus("Bus",107, Bus.lengthBus.middleBus,65), 
    new Station("Dejvická", 0, new InformationTable()),
    new Station("Čínská", 3f, new InformationTable()),
    new Station("Nádraží Podbaba", 5f, new InformationTable()),
    new Station("Výzkumný Ústav Vodohospodářský", 9f, new InformationTable()),
    new Station("V Podbabě", 12f, new InformationTable()),
    new Station("Roztocká", 15f, new InformationTable()),
    new Station("V Sedlci", 17f, new InformationTable()),
    new Station("Kamýcká - final stop", 21f, new InformationTable())
    );

transport.newRoute("B", new Tram("Tram",18, 5, Tram.tramVagons.two),
    new Station("Dejvická", 0, new InformationTable()),
    new Station("Čínská", 3f, new InformationTable()),
    new Station("Nádraží Podbaba", 5f, new InformationTable()),
    new Station("Výzkumný Ústav Vodohospodářský", 9f, new InformationTable()),
    new Station("V Podbabě", 12f, new InformationTable()),
    new Station("Roztocká", 15f, new InformationTable()),
    new Station("V Sedlci", 17f, new InformationTable()),
    new Station("Kamýcká - final stop", 21f, new InformationTable())
    );

while (true)
{
    Console.Clear();
    foreach (Route routes in transport.routes)
    {
        foreach (Station stations in routes.stations)
        {
            if(stations.TimeToArrive(routes.vehicle).Equals(0))
                Console.WriteLine("{0} number: {1} is in station: {2}\n",routes.vehicle.transportVehicle ,routes.vehicle, stations);
            else if(stations.TimeToArrive(routes.vehicle) >= 1)
                Console.WriteLine("{0} {1} arive to station: {2} in {3} minits ",routes.vehicle.transportVehicle,routes.vehicle,stations,stations.TimeToArrive(routes.vehicle));

        }
        Console.WriteLine();
    }
    /*
    foreach (Route item in transport.routes)
    {
        item.vehicle.GoVehicle(1f);
    }*/

    transport.routes[0].vehicle.GoVehicle(1);

    Console.WriteLine();
    Thread.Sleep(4000);
}

