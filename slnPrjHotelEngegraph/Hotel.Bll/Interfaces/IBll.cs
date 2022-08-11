using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Interfaces
{
    public interface IBll<T>
    {
        void Validar(T objeto);

    }
}
