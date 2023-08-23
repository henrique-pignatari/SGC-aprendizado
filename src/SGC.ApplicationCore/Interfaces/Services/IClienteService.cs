using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGC.ApplicationCore.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        void Remover(Cliente entity);
    }
}
