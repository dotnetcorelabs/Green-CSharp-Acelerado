using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    public class _01MetodosAdvanced
    {
        public _01MetodosAdvanced()
        {
            StopService();
            StopService("name");
            StopService(1);
        }

        void StopService()
        {
            //...
        }

        void StopService(string serviceName)
        {
            //...
        }

        void StopService(string serviceName, int numero)
        {
            //...
        }

        void StopService(int numero, string serviceName)
        {
            //...
        }

        void StopService(int serviceId)
        {
            //...
        }
    }
}
