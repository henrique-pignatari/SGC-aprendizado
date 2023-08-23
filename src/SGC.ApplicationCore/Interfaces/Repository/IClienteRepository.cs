using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);
    }
}
