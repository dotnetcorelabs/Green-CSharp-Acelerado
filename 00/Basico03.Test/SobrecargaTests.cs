using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Basico03.Test
{
    public class SobrecargaTests
    {
        [Fact]
        public void Test1()
        {
            //Trace.WriteLine()
            //ILogger<SobrecargaTests> logger;

            //logger.LogInformation()

            
        }

        void RecupararUsuario()
        {
            //implementacao default
            //abrir banco de dados, fazer select, fazer parse e retonar
        }

        void RecupararUsuario(string connectionString)
        {
            //implementacao default
            //abrir banco de dados (utilizar a connectionString), fazer select, fazer parse e retonar
        }
    }
}
