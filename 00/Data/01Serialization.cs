using System;

namespace Data
{
    [Serializable]
    public class Veiculo
    {
        public string Marca { get; set; }

        public string Placa { get; set; }

        public static Veiculo Default
        {
            get { return new Veiculo { Marca = "FIAT", Placa = "ABC123" }; }
        }
    }
}
