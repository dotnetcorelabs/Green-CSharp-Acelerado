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

            StopService(true, continueOnError: false);

            StopService(true, false, "outro_nome", 2);
            StopService(forceStop: true,
                        continueOnError: false,
                        serviceId: 2,
                        serviceName: "outro_nome");

            StopService(true, serviceId: 2);


            StopService(continueOnError: false, forceStop: true);



            
        }

        void StopService(bool forceStop,
                         bool continueOnError = false,
                         string serviceName = null,
                         int serviceId = 1)
        {
            //...
        }
    }
}
