using System.Collections.Generic;

namespace Hotel.Comum.Modelos
{
    public class TipoUh: Entidade
    {
        //public Guid Id { get; set; }
        public string Descricao { get; set; }
        
        /// <summary>
        /// Quantidade de adultos
        /// </summary>
        public int QtdeAdt { get; set; }

        /// <summary>
        /// Quantidade de crianças
        /// </summary>
        public int QtdeChd { get; set; }
        public double ValorDiaria { get; set; }
        public List<Uh> Uhs { get; set; }

        public List<Reserva> Reservas { get; set; }

        //public DateTime DataCriacao { get; set; }
        //public DateTime DataModificacao { get; set; }
    }
}
