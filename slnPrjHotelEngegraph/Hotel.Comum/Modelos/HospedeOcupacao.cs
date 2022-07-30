using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class HospedeOcupacao: Entidade
    {
        public Hospede Hospede { get; set; }
        public Ocupacao Ocupacao { get; set; }
    }
}
