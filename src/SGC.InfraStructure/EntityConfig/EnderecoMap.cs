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
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(e => e.CEP)
                .HasColumnType("varchar(15)")
            .IsRequired();

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(200)")
            .IsRequired();

            builder.Property(e => e.Referencia)
                .HasColumnType("varchar(400)");
        }
    }
}
