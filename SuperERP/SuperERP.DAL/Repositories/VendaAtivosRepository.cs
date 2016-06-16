﻿using SuperERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SuperERP.DAL.Repositories
{
    public class VendaAtivosRepository : Repositorio<VendasAtivas>
    {
        public ICollection<VendasAtivas> PegarVendaAtivos(int vendaId)
        {
            var venda = dbContext.VendasAtivas
                        .Include(x => x.Produto)
                        .Include(x => x.Produto.Ncm)
                        .Include(x => x.Produto.Unidade_Medida)
                        .Include(x => x.Produto.Categoria)
                        .Where(x => x.ID_Venda == vendaId).ToList();
            return venda;
        }
    }
}
