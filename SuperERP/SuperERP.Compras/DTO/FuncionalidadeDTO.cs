﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperERP.Compras.DTO
{
    public class FuncionalidadeDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PerfilDTO> Perfils { get; set; }
    }
}
