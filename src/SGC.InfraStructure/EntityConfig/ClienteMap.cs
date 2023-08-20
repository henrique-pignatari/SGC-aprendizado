using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SGC.InfraStructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder
                .HasOne(c => c.Endereco)
                .WithOne(e => e.Cliente)
                .HasForeignKey<Endereco>(e => e.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

            builder.Property(c => c.CPF)
                .HasColumnType("varchar(11)")
            .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
