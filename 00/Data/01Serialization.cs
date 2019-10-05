using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Data
{
    [Serializable]
    public class Veiculo
    {
        [JsonProperty(PropertyName = "MarcaDoCarro")]
        public string Marca { get; set; }

        public string Placa { get; set; }

        public static Veiculo Default
        {
            get { return new Veiculo { Marca = "FIAT", Placa = "ABC123" }; }
        }
    }
}
