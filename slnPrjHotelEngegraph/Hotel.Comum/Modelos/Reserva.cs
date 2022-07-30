using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class Reserva
    {
        public DateTime dateTime { get; set; }
        public DateTime DataCheckOut { get; set; }

        /// <summary>
        /// Quantidade de adultos
        /// </summary>
        public int QtdAdt { get; set; }

        /// <summary>
        /// Quantidade de criancas
        /// </summary>
        public int QtdChd { get; set; }
        public TipoUh TipoUh { get; set; }
        //public List<Reserva> Reservas { get; set; }
        public string Observacoes { get; set; }
        public int Situacao { get; set; }
    }
}
