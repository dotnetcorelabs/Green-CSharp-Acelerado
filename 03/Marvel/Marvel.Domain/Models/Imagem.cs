using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Models
{
    public class Imagem
    {
        [JsonProperty(PropertyName = "Path")]
        public string Caminho { get; set; }

        [JsonProperty(PropertyName = "Extension")]
        public string Extencao { get; set; }
    }
}
