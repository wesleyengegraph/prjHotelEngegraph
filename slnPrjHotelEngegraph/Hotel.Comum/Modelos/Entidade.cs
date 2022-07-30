﻿using System;

namespace Hotel.Comum.Modelos
{
    public class Entidade
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
    }
}
