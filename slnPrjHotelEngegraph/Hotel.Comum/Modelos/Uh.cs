using System;

namespace Hotel.Comum.Modelos
{
    public class Uh: Entidade
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Bloco { get; set; }
        public string Nivel { get; set; }
        public TipoUh TipoUh { get; set; }
    }
}
