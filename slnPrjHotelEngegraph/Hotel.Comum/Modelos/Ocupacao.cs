using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class Ocupacao: Entidade
    {
        public DateTime DataCheckIn { get; set; }
        public EnSituacaoOcupacao Situacao { get; set; }
        public Reserva Reserva { get; set; }
    }
}
