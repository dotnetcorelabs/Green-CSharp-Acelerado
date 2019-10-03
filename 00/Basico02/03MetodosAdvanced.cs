using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    class _03MetodosAdvanced
    {
        public _03MetodosAdvanced()
        {
            string message = "";
            bool isOnline = IsServiceOnline("servico1", out message);
        }

        bool IsServiceOnline(string serviceName, out string statusMessage)
        {
            var isOnline = serviceName == "servico1";
            if (isOnline)
            {
                statusMessage = "Services is currently running.";
            }
            else
            {
                statusMessage = "Services is currently stopped.";
            }
            return isOnline;
        }
    }
}
