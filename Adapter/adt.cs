using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class adt : IClient
    {
        private readonly OldService _oldService;

        public adt(OldService oldService)
        {
            _oldService = oldService;
        }

        public void Request()
        {
            // Chuyển đổi từ SpecificRequest sang Request
            _oldService.SpecificRequest();
        }
    }

}
