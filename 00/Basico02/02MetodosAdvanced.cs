using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    class _02MetodosAdvanced
    {
        public _02MetodosAdvanced()
        {
            StopService(true);
            StopService(forceStop: true);
            StopService(forceStop: true, serviceId: 2);
            StopService(forceStop: true, serviceId: 2, serviceName: "outro_nome");
        }

        void StopService(bool forceStop, string serviceName = null, int serviceId = 1)
        {
            //...
        }
    }
}
