using CadastroFornecedores.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroFornecedores.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasColumnType("varchar(6)");
            
            builder.Property(p => p.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(p => p.Complemento)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Bairro)
                .IsRequired()
                .HasColumnType("varchar(50)");
            
            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}