using System;
using Factory_method;
// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Vận chuyển bằng xe tải
        TransportService truckService = new TruckTransportService();
        truckService.StartDelivery();

        // Vận chuyển bằng tàu thủy
        TransportService shipService = new ShipTransportService();
        shipService.StartDelivery();
    }
}
