using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGC.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoService _contatoRepository;

        public ContatoService(IContatoService contatoRepository)
        {
            this._contatoRepository = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            return _contatoRepository.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            _contatoRepository.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoRepository.Remover(entity);
        }
    }
}
