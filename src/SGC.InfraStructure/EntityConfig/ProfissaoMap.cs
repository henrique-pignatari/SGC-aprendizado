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
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(400)")
            .IsRequired();

            builder.Property(p => p.CBO)
                .HasColumnType("varchar(10)")
            .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
