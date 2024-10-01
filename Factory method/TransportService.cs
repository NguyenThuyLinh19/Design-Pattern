using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
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
}
