using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.InfraStructure.Data;
using SGC.InfraStructure.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.InfraStructure.Repository
{
    public class ProfissaoRepository: EFRepository<Profissao>, IProfissaoRepository
    {
        public ProfissaoRepository(ClienteContext dbContext): base(dbContext) { }
    }
}
