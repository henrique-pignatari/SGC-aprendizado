﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.ApplicationCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {
            
        }

        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
