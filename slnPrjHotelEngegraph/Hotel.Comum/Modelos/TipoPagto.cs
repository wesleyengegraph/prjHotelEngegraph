using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class TipoPagto
    {
        public string Descricao { get; set; }
        public List<Configuracao> Configuracoes { get; set; }
    }
}
