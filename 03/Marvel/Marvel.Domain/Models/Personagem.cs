using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Models
{
    public class Personagem
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "Description")]
        public string Descricao { get; set; }

        public Imagem Thumbnail { get; set; }
    }
}
