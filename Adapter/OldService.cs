﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class OldService
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest from OldService.");
        }
    }
}
