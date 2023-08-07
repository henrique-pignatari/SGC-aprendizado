using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.InfraStructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente {
                    Nome = "Senhor senhoral",
                    CPF = "111111111"
                },

                new Cliente {
                    Nome = "Senhor senhoril",
                    CPF = "222222222"
                },
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "123456789",
                    Email = "email.contato1@email.com",
                    Cliente = clientes[0]
                },

                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "123456789",
                    Email = "email.contato2@email.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
