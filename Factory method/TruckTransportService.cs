﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class TruckTransportService : TransportService
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
