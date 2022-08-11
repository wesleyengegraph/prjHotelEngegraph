using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Dto
{
    class ObjetoDeValidacao
    {
        public List<string> Criticas { get; set; }

        public bool Sucesso => Criticas.Count <= 0;
    }
}
