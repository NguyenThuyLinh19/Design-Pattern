using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship over the sea.");
        }
    }
}
