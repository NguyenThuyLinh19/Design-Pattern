using System;

// Product - Transport (Phương tiện vận chuyển)
public interface ITransport
{
    void Deliver();
}

// Concrete Product - Truck (Xe tải)
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck on the road.");
    }
}

// Concrete Product - Ship (Tàu thủy)
public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by ship over the sea.");
    }
}

// Creator - TransportService (Dịch vụ vận chuyển)
public abstract class TransportService
{
    // Factory Method - Phương thức tạo đối tượng vận chuyển
    public abstract ITransport CreateTransport();

    // Sử dụng đối tượng do Factory Method tạo ra
    public void StartDelivery()
    {
        ITransport transport = CreateTransport();
        transport.Deliver();
    }
}

// Concrete Creator - TruckTransportService (Dịch vụ vận chuyển bằng xe tải)
public class TruckTransportService : TransportService
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

// Concrete Creator - ShipTransportService (Dịch vụ vận chuyển bằng tàu thủy)
public class ShipTransportService : TransportService
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}

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
