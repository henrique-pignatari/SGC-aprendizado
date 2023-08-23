using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGC.InfraStructure.EFRepository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext) { }

        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(c => c.ProfissoesClientes.Any(p => p.ClienteId == clienteId)).FirstOrDefault();
        }
    }
}
