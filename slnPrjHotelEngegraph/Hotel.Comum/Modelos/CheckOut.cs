using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class CheckOut
    {
        public DateTime DataCheckout { get; set; }
        public Ocupacao Ocupacao { get; set; }
        public int QtdeNoites => DataCheckout.Subtract(Ocupacao.DataCheckIn).Days;
        public TipoPagto TipoPagto { get; set; }
    }
}
